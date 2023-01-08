using RouteCards.Infrastructure;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Text += " v" + VersionService.Get();

            new CardsForm { MdiParent = this }.Show();

            if (AuthorizationService.User.RoleId != 2)
            {
                пользователиToolStripMenuItem.Visible = false;
            }
        }

        private void исполнителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ExecutorsForm { MdiParent = this }.Show();
        }

        private void маршрутныеЛистыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CardsForm { MdiParent = this }.Show();
        }

        private void документыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DocumentsForm { MdiParent = this }.Show();
        }

        private void операцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OperationsForm { MdiParent = this }.Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UsersForm { MdiParent = this }.Show();
        }

        private void технологическиеПроцессыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TechProcessesForm { MdiParent = this }.Show();
        }
    }
}
