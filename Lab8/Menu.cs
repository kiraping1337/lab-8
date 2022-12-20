namespace Lab8
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Function1_Click(object sender, EventArgs e)
        {
            Function1 Function1 = new Function1();
            Function1.Show();
        }

        private void Function2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил: Беляев Илья Андреевич, группа 6101-09.03.01D");
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res =
               MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Function4_Click(object sender, EventArgs e)
        {
            TicTacToe Function4 = new TicTacToe();
            Function4.Show();
        }

        private void Function3_Click(object sender, EventArgs e)
        {
            Sort Function3 = new Sort();
            Function3.Show(); 
        }

        private void Function5_Click(object sender, EventArgs e)
        {
            Strings Function5 = new Strings();
            Function5.Show();
        }

        private void Function6_Click(object sender, EventArgs e)
        {
            TryCatch Function6 = new TryCatch();
            Function6.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}