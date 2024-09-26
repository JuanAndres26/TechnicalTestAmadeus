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
    public class Issue5_UpdateReservation
    {
        public Mock<IReservationCrud>? moqReservationCrud;


        [TestMethod]
        public void UpdateReservationError()
        {
            //start
            moqReservationCrud = new MockReservationCrud("ReturnError").moq;
            ICrudReservations CrudReservation = new CrudReservationsImpl(moqReservationCrud.Object);
            try
            {
                //act
                var respone = CrudReservation.UpdateReservation(new Entiti.RequestUpdateReservation());
                //asset
                Assert.IsTrue(false);
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void UpdateReservationOk()
        {
            //start
            moqReservationCrud = new MockReservationCrud("FuntionReady").moq;
            ICrudReservations CrudReservation = new CrudReservationsImpl(moqReservationCrud.Object);
            try
            {
                //act
                var respone = CrudReservation.UpdateReservation(new Entiti.RequestUpdateReservation() {Tickets = new List<Ticket>() { new Ticket() { IdFly = 1 } } });
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
