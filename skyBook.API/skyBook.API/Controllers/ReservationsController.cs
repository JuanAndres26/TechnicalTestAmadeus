using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;
using skyBook.Entiti;
using skyBook.Interfaces;

namespace skyBook.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly ICrudReservations crudReservations;
        private readonly NLog.ILogger logger;

        public ReservationsController(ICrudReservations crudReservations_, NLog.ILogger logger_)
        {
            crudReservations = crudReservations_;
            logger = logger_;
        }

        // POST: api/Reservations/Create
        [HttpPost("Create")]
        [Authorize]
        public ActionResult<object> CreateReservation([FromBody] RequestcreateReservation request)
        {
            try
            {
                this.logger.Info($"start query CreateReservation in controller");
                var result = crudReservations.CreateReservation(request);
                this.logger.Info($"succesfull query CreateReservation");
                return CreatedAtAction(nameof(CreateReservation), new { idReservation = result }, result);
            }
            catch (Exception ex)
            {
                logger.Error($"Error in ReservationsController Create ERROR: {ex}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }

        // GET: api/Reservations/{idUser}
        [HttpGet("{idUser}")]
        [Authorize]
        public ActionResult<object> GetReservations(int idUser)
        {
            try
            {
                this.logger.Info($"start query GetReservations in controller");
                var result = crudReservations.GetReservations(idUser);
                this.logger.Info($"succesfull query GetReservations");
                return Ok(result);
            }
            catch (Exception ex)
            {
                logger.Error($"Error in ReservationsController GetReservations ERROR: {ex}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }

        // GET: api/Reservations/Flights
        [HttpGet("Flights")]
        [Authorize]
        public ActionResult<object> GetFlights()
        {
            try
            {
                this.logger.Info($"start query GetFlights in controller");
                var result = crudReservations.GetFlights();
                this.logger.Info($"succesfull query GetFlights");
                return Ok(result);
            }
            catch (Exception ex)
            {
                logger.Error($"Error in ReservationsController GetFlights ERROR: {ex}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }

        // GET: api/Reservations/Flight/{idFlight}
        [HttpGet("Flight/{idFlight}")]
        [Authorize]
        public ActionResult<object> GetFlight(int idFlight)
        {
            try
            {
                this.logger.Info($"start query GetFlight in controller");
                var result = crudReservations.GetFlight(idFlight);
                this.logger.Info($"succesfull query GetFlight");
                return Ok(result);
            }
            catch (Exception ex)
            {
                logger.Error($"Error in ReservationsController GetFlight ERROR: {ex}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }

        // PUT: api/Reservations/Update
        [HttpPut("Update")]
        [Authorize]
        public ActionResult<object> Update([FromBody] RequestUpdateReservation request)
        {
            try
            {
                this.logger.Info($"start query Update in controller");
                var result = crudReservations.UpdateReservation(request);
                this.logger.Info($"succesfull query UpdateReservation");
                return Ok(result);
            }
            catch (Exception ex)
            {
                logger.Error($"Error in ReservationsController Update ERROR: {ex}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }

        // DELETE: api/Reservations/Delete/{idReservation}
        [HttpDelete("Delete/{idReservation}")]
        [Authorize]
        public ActionResult<object> Delete(int idReservation)
        {
            try
            {
                this.logger.Info($"start query Delete in controller");
                var result = crudReservations.DeletReservation(idReservation);
                this.logger.Info($"succesfull query DeletReservation");
                return Ok(result);
            }
            catch (Exception ex)
            {
                logger.Error($"Error in ReservationsController Delete ERROR: {ex}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }
    }
}
