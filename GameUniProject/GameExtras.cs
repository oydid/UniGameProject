namespace GameUniProject
{
    using Models;
    using Repositories.ExtraRepository;
    using Repositories.GameExtraRepository;
    using Repositories.GameRepository;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GameExtras : Form
    {

        private readonly IGameExtraRepository _gameExtraRepository;
        private readonly IGameRepository _gameRepository;
        private readonly IExtraRepository _extraRepository;
        private readonly int _currentId;
        public GameExtras(int currentId)
        {
            _currentId = currentId;
            _gameExtraRepository = (IGameExtraRepository)StartUp.ServiceProvider.GetService(typeof(IGameExtraRepository));
            _extraRepository = (IExtraRepository)StartUp.ServiceProvider.GetService(typeof(IExtraRepository));
            _gameRepository = (IGameRepository)StartUp.ServiceProvider.GetService(typeof(IGameRepository));
            InitializeComponent();
            OnStart();
            GetData();
        }

        private void OnStart()
        {
            var extraNames = _extraRepository.GetAllExtras.Select(p => p.Name).ToArray();
            this.ComboExtraId.Items.AddRange(extraNames);
            this.InputGameName.Text = _gameRepository.GetGameById(_currentId).Name;
            ManyToManyGrid.ColumnCount = 2;
            ManyToManyGrid.Columns[0].Name = "Name";
            ManyToManyGrid.Columns[1].Name = "Description";
        }
        private void GetData()
        {
            ManyToManyGrid.Rows.Clear();
            var gameExtras = _gameExtraRepository.GetGameExtras(_currentId);
            foreach (var gameExtra in gameExtras)
            {
                string[] currentRow =
                {
                    gameExtra.Extra.Name,
                    gameExtra.Extra.Description,
                };
                ManyToManyGrid.Rows.Add(currentRow);
            }
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            Extra selectedExtra = _extraRepository.GetExtraByName(ComboExtraId.Text);
            GameExtra currentGameExtra = new GameExtra
            {
                GameId = _currentId,
                ExtraId = selectedExtra.Id
            };
            _gameExtraRepository.Add(currentGameExtra);
            GetData();
            MessageBox.Show($"Great Success");
            ComboExtraId.Text = "";
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            HomeForm f1 = new HomeForm();
            f1.ShowDialog();
        }
    }
}
