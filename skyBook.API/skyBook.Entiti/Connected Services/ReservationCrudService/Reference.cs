﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservationCrudService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ticket", Namespace="http://schemas.datacontract.org/2004/07/skyBook.Entiti")]
    public partial class Ticket : object
    {
        
        private int IdFlyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdFly
        {
            get
            {
                return this.IdFlyField;
            }
            set
            {
                this.IdFlyField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reservation", Namespace="http://schemas.datacontract.org/2004/07/skyBook.Entiti")]
    public partial class Reservation : object
    {
        
        private int IdReservationField;
        
        private int IdUserField;
        
        private ReservationCrudService.Ticket[] TicketsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdReservation
        {
            get
            {
                return this.IdReservationField;
            }
            set
            {
                this.IdReservationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdUser
        {
            get
            {
                return this.IdUserField;
            }
            set
            {
                this.IdUserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ReservationCrudService.Ticket[] Tickets
        {
            get
            {
                return this.TicketsField;
            }
            set
            {
                this.TicketsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Fligth", Namespace="http://schemas.datacontract.org/2004/07/skyBook.Entiti")]
    public partial class Fligth : object
    {
        
        private System.DateTime DateField;
        
        private string DepartureField;
        
        private string DestinationField;
        
        private int IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Departure
        {
            get
            {
                return this.DepartureField;
            }
            set
            {
                this.DepartureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Destination
        {
            get
            {
                return this.DestinationField;
            }
            set
            {
                this.DestinationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FligthDetail", Namespace="http://schemas.datacontract.org/2004/07/skyBook.Entiti")]
    public partial class FligthDetail : object
    {
        
        private System.DateTime DateField;
        
        private string DepartureField;
        
        private string DestinationField;
        
        private int IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Departure
        {
            get
            {
                return this.DepartureField;
            }
            set
            {
                this.DepartureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Destination
        {
            get
            {
                return this.DestinationField;
            }
            set
            {
                this.DestinationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReservationCrudService.IReservationCrud")]
    public interface IReservationCrud
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/createReservation", ReplyAction="http://tempuri.org/IReservationCrud/createReservationResponse")]
        ReservationCrudService.createReservationResponse createReservation(ReservationCrudService.createReservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/createReservation", ReplyAction="http://tempuri.org/IReservationCrud/createReservationResponse")]
        System.Threading.Tasks.Task<ReservationCrudService.createReservationResponse> createReservationAsync(ReservationCrudService.createReservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/deletReservation", ReplyAction="http://tempuri.org/IReservationCrud/deletReservationResponse")]
        ReservationCrudService.deletReservationResponse deletReservation(ReservationCrudService.deletReservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/deletReservation", ReplyAction="http://tempuri.org/IReservationCrud/deletReservationResponse")]
        System.Threading.Tasks.Task<ReservationCrudService.deletReservationResponse> deletReservationAsync(ReservationCrudService.deletReservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/updateReservation", ReplyAction="http://tempuri.org/IReservationCrud/updateReservationResponse")]
        ReservationCrudService.updateReservationResponse updateReservation(ReservationCrudService.updateReservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/updateReservation", ReplyAction="http://tempuri.org/IReservationCrud/updateReservationResponse")]
        System.Threading.Tasks.Task<ReservationCrudService.updateReservationResponse> updateReservationAsync(ReservationCrudService.updateReservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/getReservation", ReplyAction="http://tempuri.org/IReservationCrud/getReservationResponse")]
        ReservationCrudService.getReservationResponse getReservation(ReservationCrudService.getReservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/getReservation", ReplyAction="http://tempuri.org/IReservationCrud/getReservationResponse")]
        System.Threading.Tasks.Task<ReservationCrudService.getReservationResponse> getReservationAsync(ReservationCrudService.getReservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/getFlights", ReplyAction="http://tempuri.org/IReservationCrud/getFlightsResponse")]
        ReservationCrudService.getFlightsResponse getFlights(ReservationCrudService.getFlightsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/getFlights", ReplyAction="http://tempuri.org/IReservationCrud/getFlightsResponse")]
        System.Threading.Tasks.Task<ReservationCrudService.getFlightsResponse> getFlightsAsync(ReservationCrudService.getFlightsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/getFlight", ReplyAction="http://tempuri.org/IReservationCrud/getFlightResponse")]
        ReservationCrudService.getFlightResponse getFlight(ReservationCrudService.getFlightRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationCrud/getFlight", ReplyAction="http://tempuri.org/IReservationCrud/getFlightResponse")]
        System.Threading.Tasks.Task<ReservationCrudService.getFlightResponse> getFlightAsync(ReservationCrudService.getFlightRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createReservation", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class createReservationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idUser;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public ReservationCrudService.Ticket[] tickets;
        
        public createReservationRequest()
        {
        }
        
        public createReservationRequest(int idUser, ReservationCrudService.Ticket[] tickets)
        {
            this.idUser = idUser;
            this.tickets = tickets;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createReservationResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class createReservationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ReservationCrudService.Reservation createReservationResult;
        
        public createReservationResponse()
        {
        }
        
        public createReservationResponse(ReservationCrudService.Reservation createReservationResult)
        {
            this.createReservationResult = createReservationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deletReservation", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class deletReservationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idReservation;
        
        public deletReservationRequest()
        {
        }
        
        public deletReservationRequest(int idReservation)
        {
            this.idReservation = idReservation;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deletReservationResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class deletReservationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool deletReservationResult;
        
        public deletReservationResponse()
        {
        }
        
        public deletReservationResponse(bool deletReservationResult)
        {
            this.deletReservationResult = deletReservationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateReservation", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class updateReservationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idReservation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public ReservationCrudService.Ticket[] tickets;
        
        public updateReservationRequest()
        {
        }
        
        public updateReservationRequest(int idReservation, ReservationCrudService.Ticket[] tickets)
        {
            this.idReservation = idReservation;
            this.tickets = tickets;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateReservationResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class updateReservationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ReservationCrudService.Reservation updateReservationResult;
        
        public updateReservationResponse()
        {
        }
        
        public updateReservationResponse(ReservationCrudService.Reservation updateReservationResult)
        {
            this.updateReservationResult = updateReservationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getReservation", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getReservationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idUser;
        
        public getReservationRequest()
        {
        }
        
        public getReservationRequest(int idUser)
        {
            this.idUser = idUser;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getReservationResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getReservationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ReservationCrudService.Reservation[] getReservationResult;
        
        public getReservationResponse()
        {
        }
        
        public getReservationResponse(ReservationCrudService.Reservation[] getReservationResult)
        {
            this.getReservationResult = getReservationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getFlights", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getFlightsRequest
    {
        
        public getFlightsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getFlightsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getFlightsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ReservationCrudService.Fligth[] getFlightsResult;
        
        public getFlightsResponse()
        {
        }
        
        public getFlightsResponse(ReservationCrudService.Fligth[] getFlightsResult)
        {
            this.getFlightsResult = getFlightsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getFlight", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getFlightRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idFligth;
        
        public getFlightRequest()
        {
        }
        
        public getFlightRequest(int idFligth)
        {
            this.idFligth = idFligth;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getFlightResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getFlightResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ReservationCrudService.FligthDetail getFlightResult;
        
        public getFlightResponse()
        {
        }
        
        public getFlightResponse(ReservationCrudService.FligthDetail getFlightResult)
        {
            this.getFlightResult = getFlightResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface IReservationCrudChannel : ReservationCrudService.IReservationCrud, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class ReservationCrudClient : System.ServiceModel.ClientBase<ReservationCrudService.IReservationCrud>, ReservationCrudService.IReservationCrud
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ReservationCrudClient() : 
                base(ReservationCrudClient.GetDefaultBinding(), ReservationCrudClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IReservationCrud.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReservationCrudClient(EndpointConfiguration endpointConfiguration) : 
                base(ReservationCrudClient.GetBindingForEndpoint(endpointConfiguration), ReservationCrudClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReservationCrudClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ReservationCrudClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReservationCrudClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ReservationCrudClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReservationCrudClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ReservationCrudService.createReservationResponse createReservation(ReservationCrudService.createReservationRequest request)
        {
            return base.Channel.createReservation(request);
        }
        
        public System.Threading.Tasks.Task<ReservationCrudService.createReservationResponse> createReservationAsync(ReservationCrudService.createReservationRequest request)
        {
            return base.Channel.createReservationAsync(request);
        }
        
        public ReservationCrudService.deletReservationResponse deletReservation(ReservationCrudService.deletReservationRequest request)
        {
            return base.Channel.deletReservation(request);
        }
        
        public System.Threading.Tasks.Task<ReservationCrudService.deletReservationResponse> deletReservationAsync(ReservationCrudService.deletReservationRequest request)
        {
            return base.Channel.deletReservationAsync(request);
        }
        
        public ReservationCrudService.updateReservationResponse updateReservation(ReservationCrudService.updateReservationRequest request)
        {
            return base.Channel.updateReservation(request);
        }
        
        public System.Threading.Tasks.Task<ReservationCrudService.updateReservationResponse> updateReservationAsync(ReservationCrudService.updateReservationRequest request)
        {
            return base.Channel.updateReservationAsync(request);
        }
        
        public ReservationCrudService.getReservationResponse getReservation(ReservationCrudService.getReservationRequest request)
        {
            return base.Channel.getReservation(request);
        }
        
        public System.Threading.Tasks.Task<ReservationCrudService.getReservationResponse> getReservationAsync(ReservationCrudService.getReservationRequest request)
        {
            return base.Channel.getReservationAsync(request);
        }
        
        public ReservationCrudService.getFlightsResponse getFlights(ReservationCrudService.getFlightsRequest request)
        {
            return base.Channel.getFlights(request);
        }
        
        public System.Threading.Tasks.Task<ReservationCrudService.getFlightsResponse> getFlightsAsync(ReservationCrudService.getFlightsRequest request)
        {
            return base.Channel.getFlightsAsync(request);
        }
        
        public ReservationCrudService.getFlightResponse getFlight(ReservationCrudService.getFlightRequest request)
        {
            return base.Channel.getFlight(request);
        }
        
        public System.Threading.Tasks.Task<ReservationCrudService.getFlightResponse> getFlightAsync(ReservationCrudService.getFlightRequest request)
        {
            return base.Channel.getFlightAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IReservationCrud))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IReservationCrud))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:60922/ReservationCrudService.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ReservationCrudClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IReservationCrud);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ReservationCrudClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IReservationCrud);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IReservationCrud,
        }
    }
}
