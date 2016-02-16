﻿using System;
using SnapMD.ConnectedCare.ApiModels.Scheduling;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Models;
using SnapMD.ConnectedCare.Sdk.Wrappers;

namespace SnapMD.ConnectedCare.Sdk
{
    public class AppointmentsAdminApi : ApiCall
    {
        public AppointmentsAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        public AppointmentsAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        public ApiResponseV2<AppointmentResponse> CreateAppointment(AppointmentRequest appointment)
        {
            return Post<ApiResponseV2<AppointmentResponse>>("v2.1/clinicians/appointments", appointment);
        }

        public ApiResponseV2<AppointmentResponse> UpdateAppointment(Guid appointmentId, AppointmentRequest appointment)
        {
            return Put<ApiResponseV2<AppointmentResponse>>("v2.1/clinicians/appointments/" + appointmentId, appointment);
        }

        public ApiResponseV2<AppointmentResponse> GetAppointment(Guid appointmentId)
        {
            return MakeCall<ApiResponseV2<AppointmentResponse>>("v2.1/clinicians/appointments/" + appointmentId);
        }

        public void DeleteAppointment(Guid appointmentId)
        {
            Delete("v2.1/clinicians/appointments/" + appointmentId);
        }
    }
}
