using System;
using System.Drawing;
using System.Windows.Forms;

namespace HelloWorld;

class MainForm : Form
{
    private Button btnClick;
    private TextBox txtLog;

    public MainForm()
    {
        Text = "我的小程序";
        Size = new Size(420, 400);
        StartPosition = FormStartPosition.CenterScreen;

        // 点我按钮
        btnClick = new Button
        {
            Text = "点我",
            Size = new Size(120, 40),
            Location = new Point((ClientSize.Width - 120) / 2, 20),
            Font = new Font("Microsoft YaHei", 14, FontStyle.Bold),
        };
        btnClick.Click += (s, e) =>
        {
            txtLog.AppendText("hello world" + Environment.NewLine);
        };

        // 日志窗口
        txtLog = new TextBox
        {
            Multiline = true,
            ReadOnly = true,
            ScrollBars = ScrollBars.Vertical,
            Size = new Size(370, 280),
            Location = new Point(20, 75),
            Font = new Font("Consolas", 11),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
        };

        Controls.Add(btnClick);
        Controls.Add(txtLog);
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}
