using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YazilimSinamaFinalProje;

namespace scrumUnitTest1
{
    [TestClass]
    public class ScrumTest
    {

        [TestMethod]
        public void StateIdControl()
        {
            Scrum scrum = new Scrum();
            int result = scrum.stateId; // Program ilk calistıgında stateId==0 olmalı.
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SelectedIndexControl()
        {
            int hataKontrol;
            Scrum scrum = new Scrum();
            int tut = scrum.selectedIndex; // SelectedIndex'in -1'e eşit olması istenmeyen durumdur.
            if (tut == -1)
            {
                hataKontrol = -1;
            }
            else
            {
                hataKontrol = 0;
            }
            Assert.AreEqual(0, hataKontrol);

        }

        [TestMethod]
        public void SelectedControl()
        {
            Scrum scrum = new Scrum();
            bool tut = scrum.selected; // Selected'in program açilirken false olmasini istiyoruz.
            Assert.AreEqual(false, tut);

        }

    }
}
