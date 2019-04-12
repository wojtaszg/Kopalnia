using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadDom
{

    public partial class Kopalnia : Form
    {
        private int Counter = 1;                // liczba naciśnięć przycisku pauzowania/startu w czasie trawnia programu
        private int timeCounter = 0;            // zmienna licząca czas
        private int money = 0;                  // zmienna licząca aktualny stan złota
        private int howManyWorkers = 0;         // zmienna przechowująca liczbę pracowników
        private int howManyWagons = 0;          // zmienna przechowująca liczbę wagonów
        private int moneyIncreasePerSecond = 0;                  // zmienna licząca przychód złota na sekundę
        private int diamondIncreasePerSecond = 0;                // zmienna licząca przychód diamentów na sekundę
        private int diamonds = 0;               // zmienna licząca aktualną ilość diamentów
        private int randomSituationTime;                 // zmienna przechowująca wartość czasu losowej sytuacji (strajku robotników)
        private int randomCrashTime;            // zmienna przechowująca wartość czasu losowej awarii kopalni
        private int repair = 0;                 // ilość napraw kopalni po awariach
        private int workerUpgrade = 0;          // ilość ulepszeń pracownika
        private int wagonUpgrade = 0;           // ilość ulepszeń wagonu
        private int tradeUnionCounter = 0;      // licznik poziomu związku zawodowego
        private int tradeUnionUpgrade = 0;      // ilość ulepszeń

        //lista przechowująca utworzonych pracowników
        public List<Worker> Workers { get; set; }
        //lista przechowująca utworzone wagony
        public List<Wagon> Wagons { get; set; }
        //lista przechowująca utworzone związki zawodowe
        public List<TradeUnion> tradeUnions { get; set; }
        //konstruktor
        public Kopalnia()
        {
            InitializeComponent();
            //wylosowanie czasu strajku między 30 a 60 sekundą każdej minuty
            randomSituationTime = action(30, 60);
            //wylosowanie czasu awarii odbywającej się co 75 sekund między 50 a 75
            randomCrashTime = action(50, 75);
            //tworzenie nowej listy pracowników
            Workers = new List<Worker>();
            //tworzenie nowej listy wagonów
            Wagons = new List<Wagon>();
            //tworzenie nowej listy związku zawodowego
            tradeUnions = new List<TradeUnion>();
            //utworzenie obiektu klasy związku zawodowego
            TradeUnion trade = new TradeUnion();
            //dodanie obiektu do listy
            tradeUnions.Add(trade);
        }
        //funckja losuje i zwraca liczbę należącą do podanego przedziału
        int action(int a, int b)
        {
            Random value = new Random();
            return value.Next(a, b);
        }
        //meotda odpowiedzialna za uruchomienie/pauzowanie gry
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //sprawdzenie czy liczba "kliknięć" jest parzysta co odpowiada startowaniu gry
            if (Counter % 2 == 1)
            {
                //rozpoczęcie gry
                timer.Start();
                //zmiana napisu na przycisku
                buttonStart.Text = "Pauza";
                //zmiana koloru przycisku
                buttonStart.BackColor = Color.Red;
            }
            else
            {
                //pauza
                timer.Stop();
                buttonStart.Text = "Start";
                buttonStart.BackColor = Color.Green;
            }
            //inkrementacja licznika kliknięć 
            Counter++;
        }

        //metoda czasu wykonująca się co sekundę (interval 1000ms)
        private void timer_Tick(object sender, EventArgs e)
        {
            //inkrementacja licznika czasu co każdą sekundę
            timeCounter++;
            //zmienne przechowujące minuty i sekundy trwającej rozgrywki
            int minutes = timeCounter / 60;
            int seconds = timeCounter % 60;
            //zmiana czasu z liczby na string
            if(seconds>9)
                textBoxTime.Text = "0" + minutes.ToString() + " : " + seconds.ToString();
            else
                textBoxTime.Text = "0" + minutes.ToString() + " : 0" + seconds.ToString();
            //co 40 sekund związki zawodowe pobierają opłatę
            if (timeCounter%40==0)
            {
                tradeUnionCounter++;
            }
            //zmienne przechowujące chwilowe wartości liczby pracowników, ich wynagrodzenia, poziomu, liczby wagonów, ich przychodu
            int currentNumberOfWorkers, currentWorkerSalary, currentLevelOfWorkers,currentNumberOfWagons,currentWagonIncome;
            //Warunek jeśli w liście pracowników znajdują się elementy
            if (Workers.Count != 0)
            {
                 currentNumberOfWorkers = Workers.Count;
                 currentLevelOfWorkers = Workers[currentNumberOfWorkers - 1].workerLevel;
                 currentWorkerSalary = Workers[currentNumberOfWorkers - 1].workerSalary;
            }
            //kiedy lista jest pusta inicjujemy zmienne wartością 0
            else
            {
                 currentNumberOfWorkers = 0;
                 currentLevelOfWorkers = 0;
                 currentWorkerSalary = 0;
            }
            //Warunek jeśli w liście wagonów znajdują się elementy
            if (Wagons.Count != 0)
            {
                currentNumberOfWagons = Wagons.Count;
                currentWagonIncome = Wagons[currentNumberOfWagons-1].wagonLevel * Wagons[currentNumberOfWagons - 1].wagonVelocity;
            }
            //kiedy lista jest pusta inicjujemy zmienne wartością 0
            else
            {
                currentNumberOfWagons = 0;
                currentWagonIncome = 0;
            }
            //zmienne przechowujące wartości opłat pobieranych przez związek zawodowy
            int tradeBudget = tradeUnions[tradeUnions.Count - 1].Budget;
            int tradeDiamond = tradeUnions[tradeUnions.Count - 1].Diamond;
            //przyrost złota co sekundę
            moneyIncreasePerSecond += 2 + currentNumberOfWorkers * (currentLevelOfWorkers-currentWorkerSalary) + 2 * currentNumberOfWagons * currentWagonIncome;
          
            int valueOfRepairing=0;
            //kosztn naprawy wzrasta o 100$ za każdym razem
            for(int i=0; i < repair; i++)
            {
                valueOfRepairing += 100 * repair;
            } 
            //aktualny stan złota 
            money = moneyIncreasePerSecond - (30 * currentNumberOfWorkers) - (50 * currentNumberOfWagons) - (valueOfRepairing) - tradeUnionCounter * tradeBudget;
            //zmiana z liczby na string
            textBoxMoney.Text = money.ToString();
            //funkcja zmieniająca kolor przycisku oraz możliwość kliknięcia w niego gdy ilość zdobytego złota na to pozwala
            greenButtonToBuy();
            //przyznawanie diamentu co 6 sekund
            if (timeCounter % 6 == 0)
            {
                diamondIncreasePerSecond++;
            }
            //aktualny stan diamentów
            diamonds = diamondIncreasePerSecond - workerUpgrade * 5 - wagonUpgrade * 10 - 5*tradeUnionUpgrade - tradeUnionCounter * tradeDiamond;
            //zmiana liczby diamentów na string
            textBoxDiamond.Text = diamonds.ToString();
            //funckja zmienijąca kolor przycisku oraz możliwość kliknięci w niego gdy ilość uzyskanych diamentów pozwala na wykonanie tej czynności
            buttonUpgradeEnable();
            //strajk
            if (timeCounter % 60 == randomSituationTime)
            {
                //zatrzymanie czasu
                timer.Stop();

                //
                if (MessageBox.Show("Strajk robotników. Żądają podwyżki o 1$", "Strajk w kopalni", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //dla wszystkich elementów listy
                    for (int i = 0; i < Workers.Count; i++)
                    {
                        //wzrost pensji o 1$
                        Workers[i].workerSalary ++;
                    }
                }
                else
                {
                    MessageBox.Show("Robotnicy pracują z mniejszą efektywnością", "Strajk");
                    //dla wszystkich elementów listy
                    for (int i=0; i<Workers.Count; i++)
                    {
                        //zmniejszenie poziomu efektywności pracy robotnika
                        Workers[i].workerLevel--;
                    }
                }
                //wznowienie czasu
                timer.Start();
            }
            //awaria kopalni (odbywa się co 75 sekund)
            if (timeCounter % 75 == randomCrashTime)
            {
                //zatrzymanie czasu
                timer.Stop();
                //zmienna przechowująca aktualne wydatki na naprawę
                int Cash = (repair+1) * 100;
                //wysłanie wiadomości o kosztach naprawy
                MessageBox.Show("Awaria kopalni. Koszty naprawy to: " + Cash.ToString() + "$", "Awaria");
                //inkrementacja liczby napraw/awarii
                repair ++;
                //włączeniu czasu
                timer.Start();
            }
            //gra kończy się po zdobyciu 10000 złota
            if (money >= 10000)
            {
                timer.Stop();
                MessageBox.Show("Gratulacje wygrałeś/aś. Twój czas to: 0" + timeCounter / 60 + ":" + timeCounter % 60, "Wygrana");
                //zamknięcie programu
                Close();
            }
        }

        //metoda kończąca pracę programu po kliknięciu
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //metoda kupująca robotnika
        private void buttonBuyWorker_Click(object sender, EventArgs e)
        {
            //Warunek kupna robotnika: aktualna ilość złota > 30 oraz gra nie może być zapauzowana
            if (money >= 30 && Counter % 2 == 0)
            {
              
                if (workerUpgrade == 0)
                {
                    //tworzenie nowego obiektu klasy Worker
                    Worker worker = new Worker();
                    //dodanie obiektu do listy pracowników
                    Workers.Add(worker);
                }
                if (workerUpgrade == 1)
                {
                    //tworzenie nowego obiektu klasy UpgradedWorker
                    UpgradedWorker upgradedWorker = new UpgradedWorker();
                    //dodanie do listy
                    Workers.Add(upgradedWorker);
                }
                if (workerUpgrade == 2)
                {
                    //tworzenie obiektu klasy MasterWorker
                    MasterWorker masterWorker = new MasterWorker();
                    //dodanie do listy
                    Workers.Add(masterWorker);
                }
                //liczba elementów listy
                howManyWorkers = Workers.Count;
                //zmiana liczby aktualnych robotników wyświeltanych w textboxie
                textBoxHowManyWorkers.Text = howManyWorkers.ToString();
            }
        }

        //funkcja zmieniająca dostępność oraz kolor przycisków do kupowania
        void greenButtonToBuy()
        {
            //Warunek możliwości naciśnięcia przycisku kupna pracownika
            if (money >= 30)
            {
                //możliwość naciśnięcia przycisku
                buttonBuyWorker.Enabled = true;
                //zmiana koloru przycisku na złoty
                buttonBuyWorker.BackColor = Color.Gold;
            }
            else
            {
                //brak możliwości
                buttonBuyWorker.Enabled = false;
                //zmiana koloru przycisku na szary
                buttonBuyWorker.BackColor = Color.LightGray;
            }

            //Warunek możliwości naciśnięcia przycisku kupna wagonu
            if (money >= 50)
            {
                //możliwość naciśnięcia przycisku
                buttonBuyWagon.Enabled = true;
                //zmiana koloru przycisku na złoty
                buttonBuyWagon.BackColor = Color.Gold;
            }
            else
            {
                //brak możliwości
                buttonBuyWagon.Enabled = false;
                //zmiana koloru przycisku
                buttonBuyWagon.BackColor = Color.LightGray;
            }

        }
        //metoda kupująca wagon
        private void buttonBuyWagon_Click(object sender, EventArgs e)
        {
            //warunek kupna wagonu: aktualna ilość złota >= 50 oraz gra nie może być zapauzowana
            if (money >= 50 && Counter % 2 == 0 && wagonUpgrade == 0)
            {
                //tworzenie obiektu klasy wagon
                Wagon wagon = new Wagon();
                //dodanie do listy
                Wagons.Add(wagon);
            }
            if(wagonUpgrade == 1)
            {
                //tworzenie obiektu klasy UpgradedWagon
                UpgradedWagon upgradedWagon = new UpgradedWagon();
                Wagons.Add(upgradedWagon);
            }
            if(wagonUpgrade == 2)
            {
                //tworzenie obiektu klasy MasterWagon
                MasterWagon masterWagon = new MasterWagon();
                Wagons.Add(masterWagon);
            }
            //liczba elementów listy wagonów
                howManyWagons = Wagons.Count;
                //zmiana liczby wagonów wyświeltanych w textboxie
                textBoxHowManyWagons.Text = howManyWagons.ToString();
        }
        //metoda ulepszająca robotników
        private void buttonWorkerUpgrade_Click(object sender, EventArgs e)
        {
            //Warunek ulepszenia robotnika: aktualna ilość diamentów >= 5 oraz poziom ulepszenia == 0  (bazowy poziom ulepszenia robotnika to 0)
            if (diamonds >= 5 && workerUpgrade == 0)
            {
                //zmiana atrybutów wszystkich obiektów z listy
                for (int i=0; i<Workers.Count; i++)
                {
                    //po ulepszeniu obiekty klasy Worker znajdujące się na liście przyjmują wartości atrybutów jak w klasie UpgradedWorker
                    Workers[i].workerLevel = 4;
                    Workers[i].workerSalary = 2;
                }   
                //zmiana ikony robotnika (ulepszona)
                pictureBoxWorker.ImageLocation = @"C:\Users\Wojtek\Documents\kredek\zadDom1\robotnik.jpg";
                //progres o 50% paska "ulepszenia"
                progressBarWorkerUpgrade.Increment(50);
                buttonWorkerUpgrade.Text = "Ostatnie ulepszenie";
            }
            //Warunek kiedy poziom ulepszenia robotnika == 1
            if (workerUpgrade == 1)
            {
                //po ulepszeniu obiekty klasy UpgradedWorker oraz Worker znajdujące się na liście przyjmują wartości atrybutów jak w klasie MasterWorker
                for (int i = 0; i < Workers.Count; i++)
                {
                    Workers[i].workerLevel = 6;
                    Workers[i].workerSalary = 3;
                }
                //zmiana napisu na przycisku
                buttonWorkerUpgrade.Text = "---";
                //zmiana koloru przycisku
                buttonWorkerUpgrade.BackColor = Color.LightGray;
                //Brak możliwości naciśnięcia przycisku
                buttonWorkerUpgrade.Enabled = false;
                progressBarWorkerUpgrade.Increment(50);
            }
            //inkrementacja poziomu ulepszenia robotnika
            workerUpgrade++;
        }
        //metoda ulepszająca wagony
        private void buttonWagonUpgrade_Click(object sender, EventArgs e)
        {
            //Warunek ulepszenia wagonu: aktualna ilość diamentów >= 10 oraz poziom ulepszenia wagonu == 0 (bazowy poziom wagonu to 0)
            if (diamonds >= 10 && wagonUpgrade == 0)
            {
                //po ulepszeniu obiekty klasy Wagon znajdujące się na liście przyjmują wartości atrybutów jak w klasie UpgradedWagon
                for (int i=0; i<Wagons.Count; i++)
                {
                    Wagons[i].wagonLevel = 3;
                    Wagons[i].wagonVelocity = 2;
                }
                //zmiana ikony
                pictureBoxWagon.ImageLocation = @"C:\Users\Wojtek\Documents\kredek\zadDom1\wagon.jpg";
                progressBarWagonUpgrade.Increment(50);
                buttonWagonUpgrade.Text = "Ostatnie ulepszenie";
            }
            if (wagonUpgrade == 1)
            {
                //po ulepszeniu obiekty klasy Wagon i UpgradedWagon znajdujące się na liście przyjmują wartości atrybutów jak w klasie MasterWagon
                for (int i = 0; i < Wagons.Count; i++)
                {
                    Wagons[i].wagonLevel = 4;
                    Wagons[i].wagonVelocity = 3;
                }
                 //zmiana napisu na przycisku
                buttonWagonUpgrade.Text = "---";
                //zmiana koloru przycisku
                buttonWagonUpgrade.BackColor = Color.LightGray;
                buttonWagonUpgrade.Enabled = false;
                progressBarWagonUpgrade.Increment(50);
            }
          //inkrementacja poziomu ulepszenia wagonu
            wagonUpgrade++;
        }
        //funkcja zmieniająca dostępność oraz kolor przycisków do ulepszania
        void buttonUpgradeEnable()
        {
            if (diamonds < 5)
            {
                buttonWorkerUpgrade.Enabled = false;
            }
            else
            {
                buttonWorkerUpgrade.Enabled = true;
            }

            if (diamonds < 10)
            {
                buttonWagonUpgrade.Enabled = false;
            }
            else
            {
                buttonWagonUpgrade.Enabled = true;
            }
        }

        //metoda ulepszająca związki zawodowe
        private void buttonTradeUnion_Click(object sender, EventArgs e)
        {
            //Warunek pierwszego ulepszenia
            if(diamonds >= 5 && tradeUnionUpgrade==0)
            {
                progressBarTradeUnion.Increment(50);
                //tworzenie obiektu klasy TradeUnionUpgrade
                TradeUnionUpgrade tradeUnionUpgrade = new TradeUnionUpgrade();
                //dodanie go do listy związków zawodowych
                tradeUnions.Add(tradeUnionUpgrade);
            }
            if(diamonds >= 5 && tradeUnionUpgrade == 1)
            {
                progressBarTradeUnion.Increment(50);
                //tworzenie obiektu klasy TradeUnionFinalForm
                TradeUnionFinalForm tradeUnionFinalForm = new TradeUnionFinalForm();
                //dodanie go do listy związków zawodowych
                tradeUnions.Add(tradeUnionFinalForm);
                buttonTradeUnion.Enabled = false;
            }
            //inkrementacja poziomu ulepszenia
            tradeUnionUpgrade++;
        }
    }
}
