namespace WaffaSystem.Legacy.UI;

public sealed class MainForm : Form
{
    public MainForm()
    {
        Text = "WAFFA System — Preservation Reconstruction";
        StartPosition = FormStartPosition.CenterScreen;
        Width = 1100;
        Height = 700;

        var menu = new MenuStrip();

        var salesItem = new ToolStripMenuItem("Nova Venda");
        var categoryItem = new ToolStripMenuItem("Cadastro de Categoria");
        var supplierItem = new ToolStripMenuItem("Cadastro de Fornecedor");
        var productItem = new ToolStripMenuItem("Cadastro de Produtos");

        productItem.Click += (_, _) => new ProductForm().ShowDialog(this);

        menu.Items.Add(salesItem);
        menu.Items.Add(categoryItem);
        menu.Items.Add(supplierItem);
        menu.Items.Add(productItem);

        Controls.Add(menu);
        MainMenuStrip = menu;

        var title = new Label
        {
            AutoSize = true,
            Text = "WAFFA System",
            Font = new Font(Font.FontFamily, 28, FontStyle.Bold),
            Left = 35,
            Top = 90
        };

        var subtitle = new Label
        {
            AutoSize = true,
            Text = "Faithful reconstruction of the 2012 graduation project",
            Left = 40,
            Top = 150
        };

        Controls.Add(title);
        Controls.Add(subtitle);
    }
}
