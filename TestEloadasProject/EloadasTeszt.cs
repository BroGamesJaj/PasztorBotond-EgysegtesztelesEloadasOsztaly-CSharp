using EloadasProject;
using NUnit.Framework;
namespace TestEloadasProject {
    public class Tests {
        [Test]
        public void Constructor_ArgumentException() {
            Assert.Throws<ArgumentException>(() => new Eloadas(0, 2));
            Assert.Throws<ArgumentException>(() => new Eloadas(2, 0));
            Assert.Throws<ArgumentException>(() => new Eloadas(0, 0));
        }

        [Test]
        public void Lefoglal_Igaz() {
            var eloadas = new Eloadas(5, 5);
            Assert.That(eloadas.Lefoglal(), Is.EqualTo(true));
        }

        [Test]
        public void Lefoglal_Tele() {
            var eloadas = new Eloadas(1, 1);
            eloadas.Lefoglal();
            Assert.That(eloadas.Lefoglal(), Is.EqualTo(false));
        }

        [Test]
        public void GetSzabadHelyek_SzabadHelyekSzamatAdjaVissza() {
            var eloadas = new Eloadas(3, 3);
            Assert.That(eloadas.getSzabadHelyek, Is.EqualTo(9));
        }

        [Test]
        public void GetSzabadHelyek_SzabadHelyekSzamatAdjaVisszaLefoglalasUtan() {
            var eloadas = new Eloadas(3, 3);
            eloadas.Lefoglal();
            Assert.That(eloadas.getSzabadHelyek, Is.EqualTo(8));
        }

        [Test]
        public void GetTeli_Igaz() {
            var eloadas = new Eloadas(1, 1);
            eloadas.Lefoglal();
            Assert.That(eloadas.getTeli, Is.EqualTo(true));
        }

        [Test]
        public void GetTeli_Hamis() {
            var eloadas = new Eloadas(1, 1);
            Assert.That(eloadas.getTeli, Is.EqualTo(false));
        }
        [Test]
        public void Foglalt_ArgumentException() {
            var eloadas = new Eloadas(3, 3);
            Assert.Throws<ArgumentException>(() => eloadas.Foglalt(1, 0));
            Assert.Throws<ArgumentException>(() => eloadas.Foglalt(0, 1));
            Assert.Throws<ArgumentException>(() => eloadas.Foglalt(5, 2));
            Assert.Throws<ArgumentException>(() => eloadas.Foglalt(1, 4));
        }

        [Test]
        public void Foglalt_Igaz() {
            var eloadas = new Eloadas(2, 2);
            eloadas.Lefoglal();
            Assert.That(eloadas.Foglalt(1, 1), Is.EqualTo(true));
        }

        [Test]
        public void Foglalt_Hamis() {
            var eloadas = new Eloadas(2, 2);
            eloadas.Lefoglal();
            Assert.That(eloadas.Foglalt(2, 2), Is.EqualTo(false));
        }
    }
}