using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KN_Carousel1
{
    public partial class MainPage : ContentPage
    {
        public class Temperament
        {
            public string Name { get; set; }
            public string Nastroy { get; set; }
            public string Details { get; set; }
            public string ImageUrl { get; set; }
            public string Test { get; set; }
        }



        public MainPage()
        {


            CarouselView carouselView = new CarouselView();
            //{
            //    ItemTemplate = new MonkeyDataTemplateSelector {  }
            //}
            carouselView.SetBinding(ItemsView.ItemsSourceProperty, "Темпераменты");

            carouselView.ItemTemplate = new DataTemplate(() =>
            {
                Label nameLabel = new Label {  };
                nameLabel.SetBinding(Label.TextProperty, "Холерик");

                Label testLabel = new Label { };
                nameLabel.SetBinding(Label.TextProperty, "https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");

                Image image = new Image {  };
                image.SetBinding(Image.SourceProperty, "holerik.jpg");

                Label nastroyLabel = new Label {  };
                nastroyLabel.SetBinding(Label.TextProperty, "Редко видна улыбка на лице");

                Label detailsLabel = new Label {  };
                detailsLabel.SetBinding(Label.TextProperty, "Человека холерического темперамента можно охарактеризовать как быстрого," +
                    " порывистого," +
                    " способного отдаваться делу со страстностью," +
                    " преодолевать значительные трудности," +
                    " но, в то же время, неуравновешенного, склонного к бурным эмоциональным вспышкам и резким сменам настроения.");
                //*Холерик* *Холерик * *Холерик * *Холерик * *Холерик * *Холерик * *Холерик * *Холерик * *Холерик * *Холерик *
                Label nameLabel1 = new Label { };
                nameLabel.SetBinding(Label.TextProperty, "Флегматик");

                Label testLabel1 = new Label { };
                nameLabel.SetBinding(Label.TextProperty, "https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");

                Image image1 = new Image { };
                image.SetBinding(Image.SourceProperty, "flegmatik.jpg");

                Label nastroyLabel1 = new Label { };
                nastroyLabel.SetBinding(Label.TextProperty, "Редко видна улыбка на лице, чаще задумчивость и спокойствие");



                Label detailsLabel1 = new Label { };
                detailsLabel.SetBinding(Label.TextProperty, ("Человека флегматического темперамента можно охарактеризовать как медлительного, спокойного," +
                    " с устойчивыми стремлениями и более или менее постоянным настроением, со слабым внешним выражением душевных состояний." +
                    " Флегматик отличается сильным, уравновешенным, инертным типом нервной системы. Такие люди имеют надёжную память, а их решение является продуманным, взвешенным и без риска"));
                //*Флегматик* *Флегматик* *Флегматик* *Флегматик* *Флегматик* *Флегматик* *Флегматик* *Флегматик* *Флегматик*
                Label nameLabel2 = new Label { };
                nameLabel.SetBinding(Label.TextProperty, "Сангвиник");

                Label testLabel2 = new Label { };
                nameLabel.SetBinding(Label.TextProperty, "https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");

                Image image2 = new Image { };
                image.SetBinding(Image.SourceProperty, "sangvinik.png");

                Label nastroyLabel2 = new Label { };
                nastroyLabel.SetBinding(Label.TextProperty, "Часто улыбается,радуется жизни");

                Label detailsLabel2 = new Label { };
                detailsLabel.SetBinding(Label.TextProperty, "это личность, характеризующаяся высокой психической активностью, энергичностью, работоспособностью, быстротой и живостью движений," +
                    " разнообразием и богатством мимики, быстрым темпом речи" +
                    ". Сангвиник стремится к частой смене впечатлений, легко и быстро отзывается на окружающие события, общителен.");
                //*Сангвиник* *Сангвиник* *Сангвиник* *Сангвиник* *Сангвиник* *Сангвиник* *Сангвиник* *Сангвиник* *Сангвиник*


                Label nameLabel3 = new Label { };
                nameLabel.SetBinding(Label.TextProperty, "Меланхолик");

                Label testLabel3 = new Label { };
                nameLabel.SetBinding(Label.TextProperty, "https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");

                Image image3 = new Image { };
                image.SetBinding(Image.SourceProperty, "melanholik.png");

                Label nastroyLabel3 = new Label { };
                nastroyLabel.SetBinding(Label.TextProperty, "Сложная личность, чаще грустит.");

                Label detailsLabel3 = new Label { };
                detailsLabel.SetBinding(Label.TextProperty, "характеризующийся инертностью нервной системы, слабостью процессов возбуждения и торможения при их неуравновешенности " +
                    "(характерно преобладание процессов торможения), повышенной чувствительностью и высокой реактивностью психики.");
                //*Меланхолик* *Меланхолик* *Меланхолик* *Меланхолик* *Меланхолик* *Меланхолик* *Меланхолик* *Меланхолик* *Меланхолик*


                






                StackLayout stackLayout = new StackLayout
                {
                    Children = { nameLabel, image, nastroyLabel, detailsLabel ,testLabel,
                        nameLabel1 , image1 , nastroyLabel1 , detailsLabel1 , testLabel1,
                        nameLabel2 , image2 , nastroyLabel2 , detailsLabel2 , testLabel2,
                        nameLabel3 , image3 , nastroyLabel3 , detailsLabel3 , testLabel3,
                        
                    }
                };

                Frame frame = new Frame {  };
                StackLayout rootStackLayout = new StackLayout
                {
                    Children = { frame }
                };

                return rootStackLayout;
            });
        }
    }
    //public class MonkeyDataTemplateSelector : DataTemplateSelector
    //
    //    public DataTemplate HolerikTemperament { get; set; }
    //    public DataTemplate DrygoiTemperament { get; set; }

    //    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    //    {
    //        return ((Temperament)item).Location.Contains("Holerik") ? HolerikTemperament : DrygoiTemperament;
    //    }
    //}
}
