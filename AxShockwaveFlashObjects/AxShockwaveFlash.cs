﻿namespace BDFlashObjects
{
    using ShockwaveFlashObjects;
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;

    [DesignTimeVisible(true), Clsid("{d27cdb6e-ae6d-11cf-96b8-444553540000}")]
    internal class AxShockwaveFlash : AxHost
    {
        private AxHost.ConnectionPointCookie cookie;
        private AxShockwaveFlashEventMulticaster eventMulticaster;
        private IShockwaveFlash ocx;

        public event BDFlashObjects._IShockwaveFlashEvents_FlashCallEventHandler FlashCall;

        public event BDFlashObjects._IShockwaveFlashEvents_FSCommandEventHandler FSCommand;

        public event BDFlashObjects._IShockwaveFlashEvents_OnProgressEventHandler OnProgress;

        public event BDFlashObjects._IShockwaveFlashEvents_OnReadyStateChangeEventHandler OnReadyStateChange;

        public AxShockwaveFlash() : base("d27cdb6e-ae6d-11cf-96b8-444553540000")
        {
        }

        protected override void AttachInterfaces()
        {
            try
            {
                this.ocx = (IShockwaveFlash) base.GetOcx();
            }
            catch (Exception)
            {
            }
        }

        public virtual void Back()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("Back", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.Back();
        }

        public virtual string CallFunction(string request)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("CallFunction", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.CallFunction(request);
        }

        protected override void CreateSink()
        {
            try
            {
                this.eventMulticaster = new AxShockwaveFlashEventMulticaster(this);
                this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(_IShockwaveFlashEvents));
            }
            catch (Exception)
            {
            }
        }

        public virtual int CurrentFrame()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("CurrentFrame", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.CurrentFrame();
        }

        protected override void DetachSink()
        {
            try
            {
                this.cookie.Disconnect();
            }
            catch (Exception)
            {
            }
        }

        public virtual void DisableLocalSecurity()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("DisableLocalSecurity", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.DisableLocalSecurity();
        }

        public virtual void EnforceLocalSecurity()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("EnforceLocalSecurity", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.EnforceLocalSecurity();
        }

        public virtual int FlashVersion()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("FlashVersion", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.FlashVersion();
        }

        public virtual void Forward()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("Forward", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.Forward();
        }

        public virtual bool FrameLoaded(int frameNum)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("FrameLoaded", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.FrameLoaded(frameNum);
        }

        public virtual string GetVariable(string name)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("GetVariable", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.GetVariable(name);
        }

        public virtual void GotoFrame(int frameNum)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("GotoFrame", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.GotoFrame(frameNum);
        }

        public virtual bool IsPlaying()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("IsPlaying", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.IsPlaying();
        }

        public virtual void LoadMovie(int layer, string url)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("LoadMovie", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.LoadMovie(layer, url);
        }

        public virtual void Pan(int x, int y, int mode)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("Pan", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.Pan(x, y, mode);
        }

        public virtual int PercentLoaded()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("PercentLoaded", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.PercentLoaded();
        }

        public virtual void Play()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("Play", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.Play();
        }

        internal void RaiseOnFlashCall(object sender, _IShockwaveFlashEvents_FlashCallEvent e)
        {
            if (this.FlashCall != null)
            {
                this.FlashCall(sender, e);
            }
        }

        internal void RaiseOnFSCommand(object sender, _IShockwaveFlashEvents_FSCommandEvent e)
        {
            if (this.FSCommand != null)
            {
                this.FSCommand(sender, e);
            }
        }

        internal void RaiseOnOnProgress(object sender, _IShockwaveFlashEvents_OnProgressEvent e)
        {
            if (this.OnProgress != null)
            {
                this.OnProgress(sender, e);
            }
        }

        internal void RaiseOnOnReadyStateChange(object sender, _IShockwaveFlashEvents_OnReadyStateChangeEvent e)
        {
            if (this.OnReadyStateChange != null)
            {
                this.OnReadyStateChange(sender, e);
            }
        }

        public virtual void Rewind()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("Rewind", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.Rewind();
        }

        public virtual void SetReturnValue(string returnValue)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("SetReturnValue", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.SetReturnValue(returnValue);
        }

        public virtual void SetVariable(string name, string value)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("SetVariable", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.SetVariable(name, value);
        }

        public virtual void SetZoomRect(int left, int top, int right, int bottom)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("SetZoomRect", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.SetZoomRect(left, top, right, bottom);
        }

        public virtual void Stop()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("Stop", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.Stop();
        }

        public virtual void StopPlay()
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("StopPlay", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.StopPlay();
        }

        public virtual void TCallFrame(string target, int frameNum)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TCallFrame", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.TCallFrame(target, frameNum);
        }

        public virtual void TCallLabel(string target, string label)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TCallLabel", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.TCallLabel(target, label);
        }

        public virtual int TCurrentFrame(string target)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TCurrentFrame", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.TCurrentFrame(target);
        }

        public virtual string TCurrentLabel(string target)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TCurrentLabel", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.TCurrentLabel(target);
        }

        public virtual string TGetProperty(string target, int property)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TGetProperty", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.TGetProperty(target, property);
        }

        public virtual double TGetPropertyAsNumber(string target, int property)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TGetPropertyAsNumber", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.TGetPropertyAsNumber(target, property);
        }

        public virtual double TGetPropertyNum(string target, int property)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TGetPropertyNum", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            return this.ocx.TGetPropertyNum(target, property);
        }

        public virtual void TGotoFrame(string target, int frameNum)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TGotoFrame", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.TGotoFrame(target, frameNum);
        }

        public virtual void TGotoLabel(string target, string label)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TGotoLabel", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.TGotoLabel(target, label);
        }

        public virtual void TPlay(string target)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TPlay", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.TPlay(target);
        }

        public virtual void TSetProperty(string target, int property, string value)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TSetProperty", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.TSetProperty(target, property, value);
        }

        public virtual void TSetPropertyNum(string target, int property, double value)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TSetPropertyNum", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.TSetPropertyNum(target, property, value);
        }

        public virtual void TStopPlay(string target)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("TStopPlay", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.TStopPlay(target);
        }

        public virtual void Zoom(int factor)
        {
            if (this.ocx == null)
            {
                throw new AxHost.InvalidActiveXStateException("Zoom", AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.Zoom(factor);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0x79)]
        public virtual int AlignMode
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("AlignMode", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.AlignMode;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("AlignMode", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.AlignMode = value;
            }
        }

        [DispId(0xca), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string AllowFullScreen
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("AllowFullScreen", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.AllowFullScreen;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("AllowFullScreen", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.AllowFullScreen = value;
            }
        }

       

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0xc9)]
        public virtual string AllowNetworking
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("AllowNetworking", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.AllowNetworking;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("AllowNetworking", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.AllowNetworking = value;
            }
        }

        [DispId(0xab), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string AllowScriptAccess
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("AllowScriptAccess", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.AllowScriptAccess;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("AllowScriptAccess", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.AllowScriptAccess = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0x7b)]
        public virtual int BackgroundColor
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("BackgroundColor", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.BackgroundColor;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("BackgroundColor", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.BackgroundColor = value;
            }
        }

        [DispId(0x88), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string Base
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Base", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Base;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Base", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.Base = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(140)]
        public virtual string BGColor
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("BGColor", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.BGColor;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("BGColor", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.BGColor = value;
            }
        }

        

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0x89)]
        public virtual string CtlScale
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("CtlScale", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Scale;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("CtlScale", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.Scale = value;
            }
        }

        [DispId(0x8a), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool DeviceFont
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("DeviceFont", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.DeviceFont;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("DeviceFont", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.DeviceFont = value;
            }
        }

        [DispId(0x8b), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool EmbedMovie
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("EmbedMovie", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.EmbedMovie;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("EmbedMovie", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.EmbedMovie = value;
            }
        }

        [DispId(170), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string FlashVars
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("FlashVars", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.FlashVars;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("FlashVars", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.FlashVars = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0x6b)]
        public virtual int FrameNum
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("FrameNum", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.FrameNum;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("FrameNum", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.FrameNum = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0xbf)]
        public virtual object InlineData
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("InlineData", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.InlineData;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("InlineData", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.InlineData = value;
            }
        }

      

        [DispId(0x6a), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool Loop
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Loop", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Loop;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Loop", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.Loop = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0x87)]
        public virtual bool Menu
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Menu", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Menu;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Menu", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.Menu = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0x66)]
        public virtual string Movie
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Movie", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Movie;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Movie", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.Movie = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(190)]
        public virtual string MovieData
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("MovieData", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.MovieData;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("MovieData", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.MovieData = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0x7d)]
        public virtual bool Playing
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Playing", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Playing;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Playing", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.Playing = value;
            }
        }

        [DispId(0xc2), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool Profile
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Profile", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Profile;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Profile", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.Profile = value;
            }
        }

        [DispId(0xc3), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string ProfileAddress
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("ProfileAddress", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.ProfileAddress;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("ProfileAddress", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.ProfileAddress = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0xc4)]
        public virtual int ProfilePort
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("ProfilePort", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.ProfilePort;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("ProfilePort", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.ProfilePort = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0x69)]
        public virtual int Quality
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Quality", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Quality;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Quality", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.Quality = value;
            }
        }

        [DispId(0x8d), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string Quality2
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Quality2", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Quality2;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("Quality2", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.Quality2 = value;
            }
        }

        [DispId(-525), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual int ReadyState
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("ReadyState", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.ReadyState;
            }
        }

        [DispId(0x86), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string SAlign
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("SAlign", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.SAlign;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("SAlign", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.SAlign = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(120)]
        public virtual int ScaleMode
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("ScaleMode", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.ScaleMode;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("ScaleMode", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.ScaleMode = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0xc0)]
        public virtual bool SeamlessTabbing
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("SeamlessTabbing", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.SeamlessTabbing;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("SeamlessTabbing", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.SeamlessTabbing = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0x9f)]
        public virtual string SWRemote
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("SWRemote", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.SWRemote;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("SWRemote", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.SWRemote = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0x7c)]
        public virtual int TotalFrames
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("TotalFrames", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.TotalFrames;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DispId(0x85)]
        public virtual string WMode
        {
            get
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("WMode", AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.WMode;
            }
            set
            {
                if (this.ocx == null)
                {
                    throw new AxHost.InvalidActiveXStateException("WMode", AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.WMode = value;
            }
        }
    }
}

