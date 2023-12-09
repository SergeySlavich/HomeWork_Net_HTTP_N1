using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HomeWork_Net_HTTP_N1
{
    public partial class MainWindow : Window
    {
        // Задание.
        // 1. Посмотреть лекцию: https://www.youtube.com/watch?v=PpdQQjPS0MA
        // Подготовить вопросы по теме лекции.
        // 2. Выбрать открытый API с бесплатным доступом. Реализовать для него десктопный http-клиент на языке C#.
        // API, которые можно использовать:
        // numbers api: http://numbersapi.com/#42
        // weather api: https://openweathermap.org/api
        // github api: https://api.github.com/
        // movies: https://www.omdbapi.com/
        // quotas: https://zenquotes.io/

        public MainWindow()
        {
            InitializeComponent();
        }
        protected async Task ViewWeather()
        {
            string _key = "ключ для openweather"; // здесь ввести ключ

            HttpClient httpClient = new HttpClient();
            string request = $"http://api.openweathermap.org/data/2.5/forecast?id=524901&appid={_key}";

            HttpResponseMessage response = await httpClient.GetAsync(request);

            TextBlock.Text = await response.Content.ReadAsStringAsync();
        }

        private void weather_Click(object sender, RoutedEventArgs e)
        {
            ViewWeather();
        }
    }
}
