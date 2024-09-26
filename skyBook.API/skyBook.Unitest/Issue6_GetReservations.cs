using Moq;
using ReservationCrudService;
using skyBook.Impl;
using skyBook.Interfaces;
using skyBook.Unitest.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.Unitest
{
    [TestClass]
    public class Issue6_GetReservations
    {
        public Mock<IReservationCrud>? moqReservationCrud;


        [TestMethod]
        public void GetReservationsError()
        {
            //start
            moqReservationCrud = new MockReservationCrud("ReturnError").moq;
            ICrudReservations CrudReservation = new CrudReservationsImpl(moqReservationCrud.Object);
            try
            {
                //act
                var respone = CrudReservation.GetReservations(1);
                //asset
                Assert.IsTrue(false);
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void GetReservationsOk()
        {
            //start
            moqReservationCrud = new MockReservationCrud("FuntionReady").moq;
            ICrudReservations CrudReservation = new CrudReservationsImpl(moqReservationCrud.Object);
            try
            {
                //act
                var respone = CrudReservation.GetReservations(1);
                //asset
                Assert.IsNotNull(respone);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
