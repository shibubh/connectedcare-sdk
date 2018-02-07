﻿namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    public class AppointmentPaymentRequisitesRequest
    {
        /// <summary>
        /// ID of the health plan or null if health plan should not be applied.
        /// </summary>
        public int? HealthPlanId { get; set; }

        /// <summary>
        /// The Customer Profile ID returned from v2/patients/payments.
        /// </summary>
        public string CimProfileId { get; set; }

        /// <summary>
        /// The Payment Profile ID corresponding to the card the patient wishes to use for the transaction.
        /// </summary>
        public string PaymentProfileId { get; set; }

        /// <summary>
        /// Consultation cost as was calculated during appointment creation. Real cost may differ.
        /// </summary>
        public decimal? ConsultationAmount { get; set; }

        /// <summary>
        /// Amount of consultation cost covered by insurance as was calculated during appointment creation. Real amount may differ.
        /// </summary>
        public decimal? CopayAmount { get; set; }

    }
}