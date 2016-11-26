﻿using OpenTK.Input;
using robotymobilne_projekt.Manual;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace robotymobilne_projekt.Settings
{
    public class ControllerSettings : IDisposable
    {
        private static readonly Lazy<ControllerSettings> instance = new Lazy<ControllerSettings>(() => new ControllerSettings());
        private readonly ObservableCollection<AbstractController> controllers;
        private Thread scanningThread;
        private readonly int latency;
        private readonly int scanTime;

        #region Default values
        private const int defaultLatency = 100;
        private const int defaultScanTime = 3000; // 3s
        #endregion

        #region Getters & Setters
        public int Latency
        {
            get
            {
                return latency;
            }
        }
        public ObservableCollection<AbstractController> Controllers
        {
            get
            {
                return controllers;
            }
        }
        #endregion

        private ControllerSettings()
        {
            latency = defaultLatency;
            scanTime = defaultScanTime;
            controllers = new ObservableCollection<AbstractController>();
            scanningThread = new Thread(scanPads);
            scanningThread.IsBackground = true;
            scanningThread.Start();
        }

        public static ControllerSettings Instance
        {
            get
            {
                return instance.Value;
            }
        }

        private void scanPads()
        {
            while (true)
            {
                for (int i = 0; i < 4; i++)
                {
                    AbstractController newGamepad = new GamepadController(i);
                    if (Joystick.GetState(i).IsConnected)
                    {
                        if (!controllers.Contains(newGamepad))
                        {
                            Controllers.Add(newGamepad);
                        }
                    }
                    else
                    {
                        if(controllers.Contains(newGamepad))
                        {
                            Controllers.Remove(newGamepad);
                        }
                    }
                }
                Thread.Sleep(scanTime);
            }
        }

        private void addDefaultKeyboardControllers()
        {
            controllers.Add(new NullObjectController("NONE"));
            controllers.Add(new KeyboardController(0, Keyboard.GetState(), Key.Up, Key.Down, Key.Left,
                Key.Right, Key.Comma, Key.Period, Key.RShift, Key.Space));
            controllers.Add(new KeyboardController(1, Keyboard.GetState(), Key.W, Key.S, Key.A, Key.D,
                Key.T, Key.Y, Key.LShift, Key.H));
        }

        public void initialize()
        {
            addDefaultKeyboardControllers();
        }

        public void Dispose()
        {
            scanningThread.Abort();
        }
    }
}
