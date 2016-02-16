﻿using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    /// <summary>
    /// Appointment creation request model.
    /// </summary>
    public class AppointmentRequest
    {
        /// <summary>
        /// Availability block id.
        /// </summary>
        public int? AvailabilityBlockId { get; set; }

        /// <summary>
        /// Appointment start time.
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Appointment end time.
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// On demand request id.
        /// </summary>
        public Guid? OnDemandRequestId { get; set; }

        /// <summary>
        /// Appointment type.
        /// </summary>
        public AppointmentTypeCode AppointmentTypeCode { get; set; }

        /// <summary>
        /// Intake metadata (Concerns and additional notes).
        /// </summary>
        public AppointmentIntakeMetadata IntakeMetadata { get; set; }
    }
}
