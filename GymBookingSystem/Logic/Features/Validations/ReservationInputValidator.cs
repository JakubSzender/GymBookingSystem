
using FluentValidation;
using GymBookingSystem.Data.Models;
using System;

namespace GymBookingSystem.Logic.Features.Validations
{
    public class ReservationInputValidator : AbstractValidator<Reservation>
    {
		private TimeSpan openHour = new TimeSpan (10,0,0);
		private TimeSpan closeHour = new TimeSpan (18,0,0);

		public ReservationInputValidator()
		{
			RuleFor(x => x.ReservationDate).NotEmpty()
				.WithMessage("This field can't be empty");
			RuleFor(x => x.StartHour).NotEmpty()
					.WithMessage("This field can't be empty");
			RuleFor(x => x.StartHour).GreaterThanOrEqualTo(openHour).LessThanOrEqualTo(closeHour)
					.WithMessage("Please pick hour form 10 to 18");
			RuleFor(x => x.MachineId).NotEmpty()
					.WithMessage("Please pick machine");
			
		}

		
	
	}


}
