using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ppap2
{
    public partial class MainWindow : Window
    {
        private Game.Entities.MainCharacter mainCharacter = new Game.Entities.MainCharacter();

        public int flag = 0;

        public MainWindow()
        {
            InitializeComponent();
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

            int hp1 = 5;
            int heal = 0;

            if (flag == 1)
            {
                System_1();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System_1();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            flag = flag + 1;

            switch (flag)
            {
                case 1:
                    System_2();
                    break;
                case 2:
                    switch (ways1)
                    {
                        case 1:
                            Next_Hidden();
                            System_4_1_1();
                            break;
                        case 2:
                            System_4_2_1();
                            break;
                    }
                    break;
                case 3:
                    switch (ways1)
                    {
                        case 1:
                            System_4_1_3();
                            break;
                        case 2:
                            System_4_2_2();
                            break;
                    }
                    break;
                case 4:
                    switch (ways2)
                    {
                        case 1:
                            System_4_1_3_1_1();
                            break;
                        case 2:
                            System_4_1_3_2_1();
                            break;
                    }
                    switch (ways1)
                    {
                        case 2:
                            System_4_2_3();
                            break;
                    }
                    break;
                case 5:
                    switch (ways2)
                    {
                        case 1:
                            System_4_1_3_1_2();
                            break;
                        case 2:
                            System_4_1_3_2_2();
                            break;
                    }
                    switch (ways1)
                    {
                        case 2:
                            System_4_2_4();
                            break;
                    }
                    break;
                case 6:
                    switch (ways2)
                    {
                        case 1:
                            System_4_1_3_1_3();
                            break;
                        case 2:
                            System_4_1_3_2_3();
                            break;
                    }
                    switch (ways1)
                    {
                        case 2:
                            System_4_2_5();
                            break;
                    }
                    break;
                case 7:
                    switch (ways2)
                    {
                        case 1:
                            End();
                            break;
                        case 2:
                            System_4_1_3_2_5();
                            break;
                    }
                    switch (ways1)
                    {
                        case 2:
                            Next_Hidden();
                            System_4_1_1();
                            break;
                    }
                    break;
                case 8:
                    switch (ways2)
                    {
                        case 2:
                            System_4_1_3_2_6();
                            break;
                    }
                    switch (ways1)
                    {
                        case 2:
                            System_4_2_6();
                            break;
                    }
                    break;
                case 9:
                    switch (ways2)
                    {
                        case 2:
                            System_4_1_3_2_7();
                            break;
                    }
                    switch (ways1)
                    {
                        case 2:
                            System_4_1_3_2_5();
                            flag = 7;
                            ways2 = 2;
                            ways1 = 0;
                            break;
                    }
                    break;
                case 10:
                    switch (ways3)
                    {
                        case 1:
                            System_4_1_3_2_7_1_1();
                            break;
                        case 2:
                            System_4_1_3_2_7_2_1();
                            break;
                    }
                    break;
                case 11:
                    switch (ways3)
                    {
                        case 1:
                            System_4_1_3_2_7_1_2();
                            break;
                        case 2:
                            System_4_1_3_2_7_2_3();
                            break;
                    }
                    break;
                case 12:
                    switch (ways3)
                    {
                        case 1:
                            System_4_1_3_2_7_1_3();
                            break;
                        case 2:
                            System_4_1_3_2_7_2_4();
                            break;
                    }
                    break;
                case 13:
                    switch (ways3)
                    {
                        case 1:
                            System_4_1_3_2_7_1_4();
                            break;
                        case 2:
                            System_4_1_3_2_7_2_5();
                            break;
                    }
                    break;
                case 14:
                    switch (ways3)
                    {
                        case 1:
                            End();
                            break;
                        case 2:
                            System_4_1_3_2_3();
                            break;
                    }
                    break;
                case 15:
                    switch (ways3)
                    {
                        case 2:
                            System_4_1_3_2_7_2_6();
                            break;
                    }
                    break;
                case 16:
                    switch (ways3)
                    {
                        case 2:
                            End();
                            break;
                    }
                    break;
            }
        }

        private void DeathButton_Click(object sender, RoutedEventArgs e)
        {
            Overback.Visibility = Visibility.Hidden;
            deathPanel.Visibility = Visibility.Hidden;
            deathText.Visibility = Visibility.Hidden;
            deathButton.Visibility = Visibility.Hidden;
            flag = 0;
            System_1();
        }

        public void DeathScreen()
        {
            Overback.Visibility = Visibility.Visible;
            deathPanel.Visibility = Visibility.Visible;
            deathText.Visibility = Visibility.Visible;
            deathText.Text = " После промаха, вы были заживо поглощены этой \nсущностью и теперь в ваших глазах одна тьма...";
            deathButton.Visibility = Visibility.Visible;
            Enemy_Hidden();
        }

        public void Numbers_Visible()
        {
            Number1.Visibility = Visibility.Visible;
            Number2.Visibility = Visibility.Visible;
        }

        public void Numbers_Hidden()
        {
            Number1.Visibility = Visibility.Hidden;
            Number2.Visibility = Visibility.Hidden;
        }

        public void Next_Visible()
        {
            Next.Visibility = Visibility.Visible;
        }

        public void Next_Hidden()
        {
            Next.Visibility = Visibility.Hidden;
        }

        public void Enemy_Visible()
        {
            Enemy.Visibility = Visibility.Visible;
        }

        public void Enemy_Hidden()
        {
            Enemy.Visibility = Visibility.Hidden;
        }

        public void End()
        {
            Overback.Visibility = Visibility.Visible;
            deathPanel.Visibility = Visibility.Visible;
            EndButton.Visibility = Visibility.Visible;
            EndText.Visibility = Visibility.Visible;
        }

        public void EndButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }






        //Основная система
        public void System_1()
        {            
            Logotip.Visibility = Visibility.Hidden;
            MainButtons.Visibility = Visibility.Hidden;
            //Background.Visibility = Visibility.Hidden;
            Next_Visible();
            Panel.Visibility = Visibility.Visible;
            Field.Visibility = Visibility.Visible;
            Field.Text = "Вы просыпаетесь в криокамере и слышите \nаварийное оповещение.";
        }

        public void System_2()
        {
            Field.Text = "Похоже, что что-то произошло.\nЧто вы проверите в первую очередь?";
            Numbers_Visible();
            Next_Hidden();
            Number1.Content = "Капитанский мостик";
            Number2.Content = "Двигательный отсек";
        }

        //ПЕРВЫЙ ВЫБОР
        public int ways1 = 0;

        private void Number1_Click(object sender, RoutedEventArgs e)
        {
            System_4_1();
            Numbers_Hidden();
            Next_Visible();
            ways1 = 1;
        }

        private void Number2_Click(object sender, RoutedEventArgs e)
        {
            Next_Visible();
            System_4_2();
            Numbers_Hidden();
            ways1 = 2;
        }

        public void System_4_1()
        {
            Field.Text = "По пути вам встречается \nкакое-то непонятное существо. Оно \nвыглядит не совсем дружелюбно.";
            Enemy_Visible();
        }

        public void System_4_1_1()
        {
            Right1.Visibility = Visibility.Visible;
            Left1.Visibility = Visibility.Visible;
            Center1.Visibility = Visibility.Visible;
            Field.Text = "Куда вы ударите?";
        }

        //СИСТЕМА ПОЕДИНКА
        public void Duel(int n)
        {
            int enemyhp = 2;
            Random rnd = new Random();
            int position = rnd.Next(0, 2);
            if (position == n)
            {
                if (ways2 == 2)
                {
                    System_4_1_3_2_4();
                    Next_Visible();
                    Enemy_Hidden();
                }
                else
                {
                    System_4_1_2();
                    Next_Visible();
                    Enemy_Hidden();
                    //enemyhp = enemyhp - 1;
                }
            }
            else
            {
                DeathScreen();
            }
        }

        private void Left1_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            Duel(n);
            Right1.Visibility = Visibility.Hidden;
            Left1.Visibility = Visibility.Hidden;
            Center1.Visibility = Visibility.Hidden;
        }

        private void Center1_Click(object sender, RoutedEventArgs e)
        {
            int n = 1;
            Duel(n);
            Right1.Visibility = Visibility.Hidden;
            Left1.Visibility = Visibility.Hidden;
            Center1.Visibility = Visibility.Hidden;
        }

        private void Right1_Click(object sender, RoutedEventArgs e)
        {
            int n = 2;
            Duel(n);
            Right1.Visibility = Visibility.Hidden;
            Left1.Visibility = Visibility.Hidden;
            Center1.Visibility = Visibility.Hidden;
        }

        public void System_4_1_2()
        {
            Field.Text = "После вашего удара это существо \nрастворилось.";
        }

        public void System_4_1_3()
        {
            Next_Hidden();
            Number3.Visibility = Visibility.Visible;
            Number3.Content = "Большая красная кнопка";
            Number4.Visibility = Visibility.Visible;
            Number4.Content = "Кнопка с подписью \n'Двигательный отсек'";
            Field.Text = "Вы зашли на капитанский мостик \nи находите здесь панель управления. \nЧто вы на ней нажмёте?";
        }

        //ВТОРОЙ ВЫБОР
        public int ways2 = 0;

        private void Number3_Click(object sender, RoutedEventArgs e)
        {
            ways2 = 1;
            Next_Visible();
            Number3.Visibility = Visibility.Hidden;
            Number4.Visibility = Visibility.Hidden;
            System_4_1_3_1();
        }

        private void Number4_Click(object sender, RoutedEventArgs e)
        {
            ways2 = 2;
            Next_Visible();
            Number3.Visibility = Visibility.Hidden;
            Number4.Visibility = Visibility.Hidden;
            System_4_1_3_2();
        }

        public void System_4_1_3_1()
        {
            Field.Text = "Вы слышите сильный взрыв и после \nэтого на корабле включается сирена.";
        }

        public void System_4_1_3_1_1()
        {
            Field.Text = "Похоже на карабле началась \nразгерметизация. Вам следует как можно \nскорее покинуть корабль.";      
        }

        public void System_4_1_3_1_2()
        {
            Field.Text = "Вы бежите к спасательным капсулам по \nнаправляющим знакам.";
        }

        public void System_4_1_3_1_3()
        {
            Field.Text = "Сидя в капсуле, под обратный \nотсчёт до отправления, вы понимаете, \nчто так и не узнаете, что же случилось \nна корабле...";
        }

        public void System_4_1_3_2()
        {
            Field.Text = "Система оповещения сообщает, что \nдверь в двигательный отсек открыта. \nВам следует как можно скорее \nтуда направится.";
        }

        public void System_4_1_3_2_1()
        {
            Field.Text = "Вы заходите в коридор с дверью, \nза которой находятся двигатели, но \nслышите как что-то приближается.";
        }

        public void System_4_1_3_2_2()
        {
            Enemy_Visible();
            Field.Text = "Перед вами возникает то же существо, \nчто и раньше.";
        }

        public void System_4_1_3_2_3()
        {
            Right1.Visibility = Visibility.Visible;
            Left1.Visibility = Visibility.Visible;
            Center1.Visibility = Visibility.Visible;
            Next_Hidden();
            Field.Text = "Куда вы ударите?";
        }

        public void System_4_1_3_2_4()
        {
            Field.Text = "После вашего удара это существо \nрастворилось.";
        }

        public void System_4_1_3_2_5()
        {
            Field.Text = "Войдя в двигательный отсек, вы \nзамечаете, что три из пяти многотонных \nдвигатей куда-то исчезло.";
        }

        public void System_4_1_3_2_6()
        {
            Field.Text = "Здесь установлены камеры \nвидеонаблюдения и следующим шагом лучше \nпроверить запись во время вашего сна.";
        }

        public void System_4_1_3_2_7()
        {
            Next_Hidden();
            Field.Text = "Куда вы пойдёте?";
            Number5.Visibility = Visibility.Visible;
            Number5.Content = "Капитанский мостик";
            Number6.Visibility = Visibility.Visible;
            Number6.Content = "Инженерный отсек";
        }

        //ТРЕТИЙ ВЫБОР
        public int ways3 = 0;

        private void Number5_Click(object sender, RoutedEventArgs e)
        {
            ways3 = 1;
            System_4_1_3_2_7_1();
            Next_Visible();
            Number5.Visibility = Visibility.Hidden;
            Number6.Visibility = Visibility.Hidden;
        }

        private void System_4_1_3_2_7_1()
        {
            Field.Text = "На капитанском мостике \nвы запустили запись с отделения \nс двигателями.";
        }

        private void System_4_1_3_2_7_1_1()
        {
            Field.Text = "На ней видно, что какие-то \nабстрактные фигуры заполнили весь отсек, \nа после их исчезновения исчезли и \nдвигатели.";
        }

        private void System_4_1_3_2_7_1_2()
        {
            Field.Text = "Похоже, находиться на этом карабле \nбольше нет смысла.";
        }

        private void System_4_1_3_2_7_1_3()
        {
            Field.Text = "Вы идёте к спасательным капсулам по \nнаправляющим знакам.";
        }

        private void System_4_1_3_2_7_1_4()
        {
            Field.Text = "Находясь в капсуле, вы понимаете, \nчто должны продолжить миссию, поэтому \nвручную задаёте направление отстыковки...";
        }

        private void Number6_Click(object sender, RoutedEventArgs e)
        {
            ways3 = 2;
            System_4_1_3_2_7_2();
            Next_Visible();
            Number5.Visibility = Visibility.Hidden;
            Number6.Visibility = Visibility.Hidden;
        }

        private void System_4_1_3_2_7_2()
        {
            Field.Text = "Зайдя в инженерный отсек, слева \nот вас вы замечаете связку с одним \nключом.";
        }

        private void System_4_1_3_2_7_2_1()
        {
            Next_Hidden();
            Field.Text = "Возьмёте их?";
            Number7.Visibility = Visibility.Visible;
            Number7.Content = "Да";
            Number8.Visibility = Visibility.Visible;
            Number8.Content = "Зачем они мне";
        }

        //ВЫБОР С КЛЮЧОМ
        public int key = 0;

        private void Number7_Click(object sender, RoutedEventArgs e)
        {
            key = 1;
            Next_Visible();
            Number7.Visibility = Visibility.Hidden;
            Number8.Visibility = Visibility.Hidden;
            System_4_1_3_2_7_2_2();
        }

        private void Number8_Click(object sender, RoutedEventArgs e)
        {
            Next_Visible();
            Number7.Visibility = Visibility.Hidden;
            Number8.Visibility = Visibility.Hidden;
            System_4_1_3_2_7_2_2();
        }

        private void System_4_1_3_2_7_2_2()
        {
            Field.Text = "На стене так же висит панель, \nс которой можно выключить подачу \nэнергии на определённые двигатели";
        }

        private void System_4_1_3_2_7_2_3()
        {
            Field.Text = "Вы отключаете исчезнувшие двигатели.";
        }

        private void System_4_1_3_2_7_2_4()
        {
            Field.Text = "Теперь на капитанском мостике \nвы можете исправить отклонение \nнаправления.";
        }

        private void System_4_1_3_2_7_2_5()
        {
            Field.Text = "По пути перед вами возникает \nкакое-то существо.";
            Enemy_Visible();
        }

        private void System_4_1_3_2_7_2_6()
        {
            Field.Text = "На мостике вы задаёте направление \nкорабля, возвращаетесь в криокамеру \nи впадаете в сон до прибытия...";
        }





        public void System_4_2()
        {

            Field.Text = "Дверь в двигательный отсек \nзаблокированна. Вам нужно разблокировать \nдверь на капитанском мостике.";
        }

        public void System_4_2_1()
        {

            Field.Text = "Рядом находилась комната \nс инструментами.";
        }

        public void System_4_2_2()
        {

            Field.Text = "Зайдя внутрь, среди всякого \nбарахла, вы нашли плазменый резак.";
        }

        public void System_4_2_3()
        {

            Field.Text = "Вы поняли, что лучшее решение, \nэто прорезать себе путь внутрь.";
        }

        public void System_4_2_4()
        {
            Field.Text = "Пока вы резали дверь, вы услышали \nстранные звуки позади себя.";
        }

        public void System_4_2_5()
        {
            Field.Text = "Обернувшись, перед вами возникло \nнепонятное существо.";
            Enemy_Visible();
        }

        public void System_4_2_6()
        {
            Field.Text = "Дверь не выдержала вашего напора \nи октрылась. Но внутри вас ждала \nнеобычная картина.";
        }
    }
}
