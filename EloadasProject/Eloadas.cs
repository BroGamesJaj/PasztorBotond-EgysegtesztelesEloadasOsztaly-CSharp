namespace EloadasProject {
    public class Eloadas {
        private bool[,] foglalasok;

        public Eloadas(int sorokSzama, int helyekSzama) {
            if (sorokSzama < 1) {
                throw new ArgumentException("A sorok száma nem nagyobb, mint 0.");
            } else if (helyekSzama < 1) {
                throw new ArgumentException("A helyek száma nem nagyobb, mint 0.");
            }
            foglalasok = new bool[sorokSzama, helyekSzama];
        }

        public bool Lefoglal() {
            for (int i = 0; i < foglalasok.GetLength(0); i++) {
                for (int j = 0; j < foglalasok.GetLength(1); j++) {
                    if (!foglalasok[i, j]) {
                        foglalasok[i, j] = true;
                        return true;
                    }
                }
            }
            return false;
        }

        public int getSzabadHelyek {
            get {
                int szabad = 0;
                for (int i = 0; i < foglalasok.GetLength(0); i++) {
                    for (int j = 0; j < foglalasok.GetLength(1); j++) {
                        if (!foglalasok[i, j]) {
                            szabad++;
                        }
                    }
                }
                return szabad;
            }
        }

        public bool getTeli {
            get {
                if (getSzabadHelyek == 0) {
                    return true;
                }
                return false;
            }
        }

        public bool Foglalt(int sorSzam, int helySzam) {
            if (sorSzam < 1 || sorSzam > foglalasok.GetLength(0)) {
                throw new ArgumentException("Érvénytelen érték a sor szám.");
            } else if (helySzam < 1 || helySzam > foglalasok.GetLength(1)) {
                throw new ArgumentException("Érvénytelen érték a hely szám.");
            }
            return foglalasok[sorSzam - 1, helySzam - 1];
        }
    }
}