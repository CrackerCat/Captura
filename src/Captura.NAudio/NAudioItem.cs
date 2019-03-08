﻿using Captura.Models;
using NAudio.CoreAudioApi;

namespace Captura.NAudio
{
    class NAudioItem : NotifyPropertyChanged, IAudioItem
    {
        public MMDevice Device { get; }

        public string Name { get; }

        public NAudioItem(MMDevice Device)
        {
            this.Device = Device;

            Name = Device.FriendlyName;
        }

        bool _active;

        public bool Active
        {
            get => _active;
            set => Set(ref _active, value);
        }

        public override string ToString() => Name;
    }
}