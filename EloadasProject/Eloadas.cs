namespace EloadasProject
{
    public class Eloadas
    {
        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if (sorokSzama < 1 || helyekSzama < 1)
            {
                throw new ArgumentException("A paramétereknek 0-nál nagyobbnak kell lennie!");
            }
            else
            {
                bool[,] foglalasok = new bool[sorokSzama, helyekSzama];
                Foglalasok = foglalasok;
            }
            
        }

        public bool[,] Foglalasok { get; set; }

        public bool Lefoglal()
        {           
            bool siker = false;
            int szamlalo = 0;            
            {
                for (int i = 0; i < Foglalasok.GetLength(0); i++)
                {
                    for (int j = 0; j < Foglalasok.GetLength(1); j++)
                        if (Foglalasok[i, j] == false)
                        {
                            Foglalasok[i, j] = true;
                            szamlalo++;
                            siker = true;
                            break;
                        }
                    if (siker)
                        break;
                }
                    
            }
            return siker;
        }

        public int getSzabadHelyek
        {
            
            get
            {   
                int szabadHelyek = 0;
                for (int i = 0; i < Foglalasok.GetLength(0); i++)
                    for (int j = 0; j < Foglalasok.GetLength(1); j++)
                        if (Foglalasok[i, j] == false)
                        {
                            szabadHelyek++;
                        }
                return szabadHelyek;
            }
            
        }

        public bool getTeli
        {
            get
            {
                bool telthaz = true;
                for (int i = 0; i < Foglalasok.GetLength(0); i++)
                    for (int j = 0; j < Foglalasok.GetLength(1); j++)
                        if (Foglalasok[i, j] == false)
                        {
                            telthaz = false;
                            break;
                        }
                return telthaz;
            }
        }


        public bool Foglalt(int sorSzam, int helySzam)
        {
            if (sorSzam < 0 || helySzam < 0)
            {
                throw new ArgumentException("A paramétereknek 0-nál nagyobbnak kell lennie!");
            }
            if (sorSzam > Foglalasok.GetLength(0) || helySzam > Foglalasok.GetLength(1))
            {
                throw new ArgumentException("Nincs ennyi sor, vagy hely!");
            }
            else
            {
                bool foglalt = false;
                for (int i = 0; i < Foglalasok.GetLength(0); i++)
                {
                    if (i == sorSzam - 1)
                    {
                        for (int j = 0; j < Foglalasok.GetLength(1); j++)
                        {
                            if (j == helySzam - 1)
                            {
                                if (Foglalasok[i, j] == true)
                                {
                                    foglalt = true;
                                    break;
                                }
                            }
                        }
                            
                    }
                }
                    
                return foglalt;
            }
        }


        public void MindenHelyFoglaltSeged()
        {
            for (int i = 0; i < Foglalasok.GetLength(0); i++)
                for (int j = 0; j < Foglalasok.GetLength(1); j++)
                    Foglalasok[i, j] = true;
        }
        

    }



}