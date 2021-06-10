namespace GameUniProject
{
    using Models;
    using Repositories.GameRepository;
    using Repositories.PublisherRepository;
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class HomeForm : Form
    {
        private readonly IGameRepository _gameRepository;
        private readonly IPublisherRepository _publisherRepository;
        public HomeForm()
        {
            _gameRepository = (IGameRepository)StartUp.ServiceProvider.GetService(typeof(IGameRepository));
            _publisherRepository = (IPublisherRepository)StartUp.ServiceProvider.GetService(typeof(IPublisherRepository));
            InitializeComponent();
            OnStart();
            GetData();
        }

        public void OnStart()
        {
            GameGridView.ColumnCount = 6;
            GameGridView.Columns[0].Name = "Id";
            GameGridView.Columns[1].Name = "Name";
            GameGridView.Columns[2].Name = "Year of publishing";
            GameGridView.Columns[3].Name = "Publisher";
            GameGridView.Columns[4].Name = "Extras";

            var publisherNames = _publisherRepository.GetAllPublishers
                .Select(p => p.Name).ToArray();
            this.InputPublisherId.Items.AddRange(publisherNames);

        }

        private void GetData()
        {
            GameGridView.Rows.Clear();
            var gamesModel = _gameRepository.GetAllGames;
            foreach(Game game in gamesModel)
            {
                string[] currentRow =
                {
                    game.Id.ToString(),
                    game.Name.ToString(),
                    game.YearReleased.ToString(),
                    game.Publisher.Name,
                    string.Join(",", game.GameExtras.Select(x=>x.Extra.Name))
                };
                GameGridView.Rows.Add(currentRow);
            }
        }

        private void InputYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Publisher selectPublisher = _publisherRepository.GetAllPublishers.SingleOrDefault(p => p.Name == InputPublisherId.Text);
            var game = new Game()
            {
                Name = InputName.Text,
                YearReleased = int.Parse(InputYear.Text),
                PublisherId = selectPublisher.Id,
            };
            int gameId = _gameRepository.Add(game);
            ClearForm();
            this.Hide();
            GameExtras f2 = new GameExtras(gameId);
            f2.ShowDialog();
            GetData();

        }

        private void ClearForm()
        {
            InputId.Text = "";
            InputName.Text = "";
            InputYear.Text = "";
            InputPublisherId.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var game = new Game()
            {
                Id = int.Parse(InputId.Text),
                Name = InputName.Text,
                YearReleased = int.Parse(InputYear.Text),
                PublisherId = _publisherRepository.GetAllPublishers.SingleOrDefault(p => p.Name == InputPublisherId.Text).Id,
            };
            _gameRepository.Update(game);
            ClearForm();
            GetData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var currentId = int.Parse(InputId.Text);
            _gameRepository.Delete(currentId);
            ClearForm();
            GetData();
        }

        private void GameGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            InputId.Text = GameGridView.Rows[rowIndex].Cells[0].Value.ToString();
            InputName.Text = GameGridView.Rows[rowIndex].Cells[1].Value.ToString();
            InputYear.Text = GameGridView.Rows[rowIndex].Cells[2].Value.ToString();
            InputPublisherId.Text = GameGridView.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void GameGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int currentId = int.Parse(GameGridView.Rows[rowIndex].Cells[0].Value.ToString());
            this.Hide();
            GameExtras f2 = new GameExtras(currentId);
            f2.ShowDialog();
        }
    }
}
