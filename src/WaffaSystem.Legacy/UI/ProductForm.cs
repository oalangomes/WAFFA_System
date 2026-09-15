using WaffaSystem.Legacy.Domain;

namespace WaffaSystem.Legacy.UI;

public sealed class ProductForm : Form
{
    private readonly TextBox _code = new() { ReadOnly = true, Text = "automático" };
    private readonly TextBox _name = new();
    private readonly TextBox _category = new();
    private readonly TextBox _supplier = new();
    private readonly NumericUpDown _quantity = new() { Maximum = 1_000_000 };
    private readonly NumericUpDown _minimum = new() { Maximum = 1_000_000 };
    private readonly NumericUpDown _maximum = new() { Maximum = 1_000_000 };
    private readonly NumericUpDown _purchasePrice = MoneyInput();
    private readonly NumericUpDown _salePrice = MoneyInput();
    private readonly TextBox _profit = new() { ReadOnly = true };
    private readonly TextBox _serial = new();
    private readonly TextBox _location = new();

    public ProductForm()
    {
        Text = "Cadastro de Produtos";
        StartPosition = FormStartPosition.CenterParent;
        Width = 760;
        Height = 640;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;

        var layout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(18),
            ColumnCount = 2,
            RowCount = 14,
            AutoScroll = true
        };

        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

        AddField(layout, 0, "Código", _code);
        AddField(layout, 1, "Descrição / Nome", _name);
        AddField(layout, 2, "Categoria", _category);
        AddField(layout, 3, "Fornecedor", _supplier);
        AddField(layout, 4, "Quantidade", _quantity);
        AddField(layout, 5, "Quantidade mínima", _minimum);
        AddField(layout, 6, "Quantidade máxima", _maximum);
        AddField(layout, 7, "Valor de compra", _purchasePrice);
        AddField(layout, 8, "Valor de venda", _salePrice);
        AddField(layout, 9, "Lucro unitário", _profit);
        AddField(layout, 10, "Serial", _serial);
        AddField(layout, 11, "Localização", _location);

        _purchasePrice.ValueChanged += (_, _) => UpdateProfit();
        _salePrice.ValueChanged += (_, _) => UpdateProfit();

        var buttons = new FlowLayoutPanel
        {
            FlowDirection = FlowDirection.RightToLeft,
            Dock = DockStyle.Fill,
            AutoSize = true
        };

        var cancel = new Button { Text = "Cancelar", AutoSize = true };
        cancel.Click += (_, _) => Close();

        var save = new Button { Text = "Salvar", AutoSize = true };
        save.Click += (_, _) => ValidateDraft();

        buttons.Controls.Add(cancel);
        buttons.Controls.Add(save);
        layout.Controls.Add(buttons, 0, 12);
        layout.SetColumnSpan(buttons, 2);

        Controls.Add(layout);
        UpdateProfit();
    }

    private static NumericUpDown MoneyInput() => new()
    {
        DecimalPlaces = 2,
        Maximum = 10_000_000,
        ThousandsSeparator = true
    };

    private static void AddField(TableLayoutPanel layout, int row, string label, Control control)
    {
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.Controls.Add(new Label { Text = label, AutoSize = true, Anchor = AnchorStyles.Left }, 0, row);
        control.Dock = DockStyle.Top;
        layout.Controls.Add(control, 1, row);
    }

    private void UpdateProfit()
    {
        _profit.Text = (_salePrice.Value - _purchasePrice.Value).ToString("C2");
    }

    private void ValidateDraft()
    {
        if (string.IsNullOrWhiteSpace(_name.Text))
        {
            MessageBox.Show(this, "Informe o nome do produto.", "WAFFA System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_maximum.Value > 0 && _minimum.Value > _maximum.Value)
        {
            MessageBox.Show(this, "A quantidade mínima não pode ser maior que a máxima.", "WAFFA System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var product = new Product
        {
            Code = 0,
            Name = _name.Text.Trim(),
            Category = EmptyToNull(_category.Text),
            Supplier = EmptyToNull(_supplier.Text),
            Quantity = decimal.ToInt32(_quantity.Value),
            MinimumQuantity = decimal.ToInt32(_minimum.Value),
            MaximumQuantity = decimal.ToInt32(_maximum.Value),
            PurchasePrice = _purchasePrice.Value,
            SalePrice = _salePrice.Value,
            Serial = EmptyToNull(_serial.Text),
            Location = EmptyToNull(_location.Text)
        };

        MessageBox.Show(
            this,
            $"Produto preparado para persistência: {product.Name}\nLucro unitário: {product.UnitProfit:C2}",
            "Preservation slice",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private static string? EmptyToNull(string value)
        => string.IsNullOrWhiteSpace(value) ? null : value.Trim();
}
