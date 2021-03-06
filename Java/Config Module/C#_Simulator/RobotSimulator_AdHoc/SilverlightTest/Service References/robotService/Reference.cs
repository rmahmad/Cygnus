﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace SilverlightTest.robotService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="robotService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/getMotion", ReplyAction="http://tempuri.org/IService/getMotionResponse")]
        System.IAsyncResult BegingetMotion(System.AsyncCallback callback, object asyncState);
        
        string EndgetMotion(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/setMotion", ReplyAction="http://tempuri.org/IService/setMotionResponse")]
        System.IAsyncResult BeginsetMotion(string newMotion, System.AsyncCallback callback, object asyncState);
        
        void EndsetMotion(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/getSensorUpdate", ReplyAction="http://tempuri.org/IService/getSensorUpdateResponse")]
        System.IAsyncResult BegingetSensorUpdate(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<double> EndgetSensorUpdate(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/updateSensor", ReplyAction="http://tempuri.org/IService/updateSensorResponse")]
        System.IAsyncResult BeginupdateSensor(double front, double left, double right, double rear, double newCompass, System.AsyncCallback callback, object asyncState);
        
        void EndupdateSensor(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/sendMessage", ReplyAction="http://tempuri.org/IService/sendMessageResponse")]
        System.IAsyncResult BeginsendMessage(string newMsg, System.AsyncCallback callback, object asyncState);
        
        void EndsendMessage(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/receiveMessage", ReplyAction="http://tempuri.org/IService/receiveMessageResponse")]
        System.IAsyncResult BeginreceiveMessage(System.AsyncCallback callback, object asyncState);
        
        string EndreceiveMessage(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : SilverlightTest.robotService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getMotionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getMotionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getSensorUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getSensorUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<double> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<double>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class receiveMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public receiveMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<SilverlightTest.robotService.IService>, SilverlightTest.robotService.IService {
        
        private BeginOperationDelegate onBegingetMotionDelegate;
        
        private EndOperationDelegate onEndgetMotionDelegate;
        
        private System.Threading.SendOrPostCallback ongetMotionCompletedDelegate;
        
        private BeginOperationDelegate onBeginsetMotionDelegate;
        
        private EndOperationDelegate onEndsetMotionDelegate;
        
        private System.Threading.SendOrPostCallback onsetMotionCompletedDelegate;
        
        private BeginOperationDelegate onBegingetSensorUpdateDelegate;
        
        private EndOperationDelegate onEndgetSensorUpdateDelegate;
        
        private System.Threading.SendOrPostCallback ongetSensorUpdateCompletedDelegate;
        
        private BeginOperationDelegate onBeginupdateSensorDelegate;
        
        private EndOperationDelegate onEndupdateSensorDelegate;
        
        private System.Threading.SendOrPostCallback onupdateSensorCompletedDelegate;
        
        private BeginOperationDelegate onBeginsendMessageDelegate;
        
        private EndOperationDelegate onEndsendMessageDelegate;
        
        private System.Threading.SendOrPostCallback onsendMessageCompletedDelegate;
        
        private BeginOperationDelegate onBeginreceiveMessageDelegate;
        
        private EndOperationDelegate onEndreceiveMessageDelegate;
        
        private System.Threading.SendOrPostCallback onreceiveMessageCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<getMotionCompletedEventArgs> getMotionCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> setMotionCompleted;
        
        public event System.EventHandler<getSensorUpdateCompletedEventArgs> getSensorUpdateCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> updateSensorCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> sendMessageCompleted;
        
        public event System.EventHandler<receiveMessageCompletedEventArgs> receiveMessageCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightTest.robotService.IService.BegingetMotion(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetMotion(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string SilverlightTest.robotService.IService.EndgetMotion(System.IAsyncResult result) {
            return base.Channel.EndgetMotion(result);
        }
        
        private System.IAsyncResult OnBegingetMotion(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((SilverlightTest.robotService.IService)(this)).BegingetMotion(callback, asyncState);
        }
        
        private object[] OnEndgetMotion(System.IAsyncResult result) {
            string retVal = ((SilverlightTest.robotService.IService)(this)).EndgetMotion(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetMotionCompleted(object state) {
            if ((this.getMotionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getMotionCompleted(this, new getMotionCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getMotionAsync() {
            this.getMotionAsync(null);
        }
        
        public void getMotionAsync(object userState) {
            if ((this.onBegingetMotionDelegate == null)) {
                this.onBegingetMotionDelegate = new BeginOperationDelegate(this.OnBegingetMotion);
            }
            if ((this.onEndgetMotionDelegate == null)) {
                this.onEndgetMotionDelegate = new EndOperationDelegate(this.OnEndgetMotion);
            }
            if ((this.ongetMotionCompletedDelegate == null)) {
                this.ongetMotionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetMotionCompleted);
            }
            base.InvokeAsync(this.onBegingetMotionDelegate, null, this.onEndgetMotionDelegate, this.ongetMotionCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightTest.robotService.IService.BeginsetMotion(string newMotion, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginsetMotion(newMotion, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void SilverlightTest.robotService.IService.EndsetMotion(System.IAsyncResult result) {
            base.Channel.EndsetMotion(result);
        }
        
        private System.IAsyncResult OnBeginsetMotion(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string newMotion = ((string)(inValues[0]));
            return ((SilverlightTest.robotService.IService)(this)).BeginsetMotion(newMotion, callback, asyncState);
        }
        
        private object[] OnEndsetMotion(System.IAsyncResult result) {
            ((SilverlightTest.robotService.IService)(this)).EndsetMotion(result);
            return null;
        }
        
        private void OnsetMotionCompleted(object state) {
            if ((this.setMotionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.setMotionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void setMotionAsync(string newMotion) {
            this.setMotionAsync(newMotion, null);
        }
        
        public void setMotionAsync(string newMotion, object userState) {
            if ((this.onBeginsetMotionDelegate == null)) {
                this.onBeginsetMotionDelegate = new BeginOperationDelegate(this.OnBeginsetMotion);
            }
            if ((this.onEndsetMotionDelegate == null)) {
                this.onEndsetMotionDelegate = new EndOperationDelegate(this.OnEndsetMotion);
            }
            if ((this.onsetMotionCompletedDelegate == null)) {
                this.onsetMotionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnsetMotionCompleted);
            }
            base.InvokeAsync(this.onBeginsetMotionDelegate, new object[] {
                        newMotion}, this.onEndsetMotionDelegate, this.onsetMotionCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightTest.robotService.IService.BegingetSensorUpdate(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetSensorUpdate(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<double> SilverlightTest.robotService.IService.EndgetSensorUpdate(System.IAsyncResult result) {
            return base.Channel.EndgetSensorUpdate(result);
        }
        
        private System.IAsyncResult OnBegingetSensorUpdate(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((SilverlightTest.robotService.IService)(this)).BegingetSensorUpdate(callback, asyncState);
        }
        
        private object[] OnEndgetSensorUpdate(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<double> retVal = ((SilverlightTest.robotService.IService)(this)).EndgetSensorUpdate(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetSensorUpdateCompleted(object state) {
            if ((this.getSensorUpdateCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getSensorUpdateCompleted(this, new getSensorUpdateCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getSensorUpdateAsync() {
            this.getSensorUpdateAsync(null);
        }
        
        public void getSensorUpdateAsync(object userState) {
            if ((this.onBegingetSensorUpdateDelegate == null)) {
                this.onBegingetSensorUpdateDelegate = new BeginOperationDelegate(this.OnBegingetSensorUpdate);
            }
            if ((this.onEndgetSensorUpdateDelegate == null)) {
                this.onEndgetSensorUpdateDelegate = new EndOperationDelegate(this.OnEndgetSensorUpdate);
            }
            if ((this.ongetSensorUpdateCompletedDelegate == null)) {
                this.ongetSensorUpdateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetSensorUpdateCompleted);
            }
            base.InvokeAsync(this.onBegingetSensorUpdateDelegate, null, this.onEndgetSensorUpdateDelegate, this.ongetSensorUpdateCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightTest.robotService.IService.BeginupdateSensor(double front, double left, double right, double rear, double newCompass, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginupdateSensor(front, left, right, rear, newCompass, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void SilverlightTest.robotService.IService.EndupdateSensor(System.IAsyncResult result) {
            base.Channel.EndupdateSensor(result);
        }
        
        private System.IAsyncResult OnBeginupdateSensor(object[] inValues, System.AsyncCallback callback, object asyncState) {
            double front = ((double)(inValues[0]));
            double left = ((double)(inValues[1]));
            double right = ((double)(inValues[2]));
            double rear = ((double)(inValues[3]));
            double newCompass = ((double)(inValues[4]));
            return ((SilverlightTest.robotService.IService)(this)).BeginupdateSensor(front, left, right, rear, newCompass, callback, asyncState);
        }
        
        private object[] OnEndupdateSensor(System.IAsyncResult result) {
            ((SilverlightTest.robotService.IService)(this)).EndupdateSensor(result);
            return null;
        }
        
        private void OnupdateSensorCompleted(object state) {
            if ((this.updateSensorCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.updateSensorCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void updateSensorAsync(double front, double left, double right, double rear, double newCompass) {
            this.updateSensorAsync(front, left, right, rear, newCompass, null);
        }
        
        public void updateSensorAsync(double front, double left, double right, double rear, double newCompass, object userState) {
            if ((this.onBeginupdateSensorDelegate == null)) {
                this.onBeginupdateSensorDelegate = new BeginOperationDelegate(this.OnBeginupdateSensor);
            }
            if ((this.onEndupdateSensorDelegate == null)) {
                this.onEndupdateSensorDelegate = new EndOperationDelegate(this.OnEndupdateSensor);
            }
            if ((this.onupdateSensorCompletedDelegate == null)) {
                this.onupdateSensorCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnupdateSensorCompleted);
            }
            base.InvokeAsync(this.onBeginupdateSensorDelegate, new object[] {
                        front,
                        left,
                        right,
                        rear,
                        newCompass}, this.onEndupdateSensorDelegate, this.onupdateSensorCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightTest.robotService.IService.BeginsendMessage(string newMsg, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginsendMessage(newMsg, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void SilverlightTest.robotService.IService.EndsendMessage(System.IAsyncResult result) {
            base.Channel.EndsendMessage(result);
        }
        
        private System.IAsyncResult OnBeginsendMessage(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string newMsg = ((string)(inValues[0]));
            return ((SilverlightTest.robotService.IService)(this)).BeginsendMessage(newMsg, callback, asyncState);
        }
        
        private object[] OnEndsendMessage(System.IAsyncResult result) {
            ((SilverlightTest.robotService.IService)(this)).EndsendMessage(result);
            return null;
        }
        
        private void OnsendMessageCompleted(object state) {
            if ((this.sendMessageCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.sendMessageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void sendMessageAsync(string newMsg) {
            this.sendMessageAsync(newMsg, null);
        }
        
        public void sendMessageAsync(string newMsg, object userState) {
            if ((this.onBeginsendMessageDelegate == null)) {
                this.onBeginsendMessageDelegate = new BeginOperationDelegate(this.OnBeginsendMessage);
            }
            if ((this.onEndsendMessageDelegate == null)) {
                this.onEndsendMessageDelegate = new EndOperationDelegate(this.OnEndsendMessage);
            }
            if ((this.onsendMessageCompletedDelegate == null)) {
                this.onsendMessageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnsendMessageCompleted);
            }
            base.InvokeAsync(this.onBeginsendMessageDelegate, new object[] {
                        newMsg}, this.onEndsendMessageDelegate, this.onsendMessageCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightTest.robotService.IService.BeginreceiveMessage(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginreceiveMessage(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string SilverlightTest.robotService.IService.EndreceiveMessage(System.IAsyncResult result) {
            return base.Channel.EndreceiveMessage(result);
        }
        
        private System.IAsyncResult OnBeginreceiveMessage(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((SilverlightTest.robotService.IService)(this)).BeginreceiveMessage(callback, asyncState);
        }
        
        private object[] OnEndreceiveMessage(System.IAsyncResult result) {
            string retVal = ((SilverlightTest.robotService.IService)(this)).EndreceiveMessage(result);
            return new object[] {
                    retVal};
        }
        
        private void OnreceiveMessageCompleted(object state) {
            if ((this.receiveMessageCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.receiveMessageCompleted(this, new receiveMessageCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void receiveMessageAsync() {
            this.receiveMessageAsync(null);
        }
        
        public void receiveMessageAsync(object userState) {
            if ((this.onBeginreceiveMessageDelegate == null)) {
                this.onBeginreceiveMessageDelegate = new BeginOperationDelegate(this.OnBeginreceiveMessage);
            }
            if ((this.onEndreceiveMessageDelegate == null)) {
                this.onEndreceiveMessageDelegate = new EndOperationDelegate(this.OnEndreceiveMessage);
            }
            if ((this.onreceiveMessageCompletedDelegate == null)) {
                this.onreceiveMessageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnreceiveMessageCompleted);
            }
            base.InvokeAsync(this.onBeginreceiveMessageDelegate, null, this.onEndreceiveMessageDelegate, this.onreceiveMessageCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SilverlightTest.robotService.IService CreateChannel() {
            return new ServiceClientChannel(this);
        }
        
        private class ServiceClientChannel : ChannelBase<SilverlightTest.robotService.IService>, SilverlightTest.robotService.IService {
            
            public ServiceClientChannel(System.ServiceModel.ClientBase<SilverlightTest.robotService.IService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BegingetMotion(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("getMotion", _args, callback, asyncState);
                return _result;
            }
            
            public string EndgetMotion(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("getMotion", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginsetMotion(string newMotion, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = newMotion;
                System.IAsyncResult _result = base.BeginInvoke("setMotion", _args, callback, asyncState);
                return _result;
            }
            
            public void EndsetMotion(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("setMotion", _args, result);
            }
            
            public System.IAsyncResult BegingetSensorUpdate(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("getSensorUpdate", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<double> EndgetSensorUpdate(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<double> _result = ((System.Collections.ObjectModel.ObservableCollection<double>)(base.EndInvoke("getSensorUpdate", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginupdateSensor(double front, double left, double right, double rear, double newCompass, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[5];
                _args[0] = front;
                _args[1] = left;
                _args[2] = right;
                _args[3] = rear;
                _args[4] = newCompass;
                System.IAsyncResult _result = base.BeginInvoke("updateSensor", _args, callback, asyncState);
                return _result;
            }
            
            public void EndupdateSensor(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("updateSensor", _args, result);
            }
            
            public System.IAsyncResult BeginsendMessage(string newMsg, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = newMsg;
                System.IAsyncResult _result = base.BeginInvoke("sendMessage", _args, callback, asyncState);
                return _result;
            }
            
            public void EndsendMessage(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("sendMessage", _args, result);
            }
            
            public System.IAsyncResult BeginreceiveMessage(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("receiveMessage", _args, callback, asyncState);
                return _result;
            }
            
            public string EndreceiveMessage(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("receiveMessage", _args, result)));
                return _result;
            }
        }
    }
}
