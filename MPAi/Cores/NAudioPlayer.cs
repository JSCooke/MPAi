﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.IO;

namespace MPAi.Cores
{
    /// <summary>
    /// Class that handles using the NAudio library to play audio files.
    /// </summary>
    public class NAudioPlayer
    {
        private WaveFileReader reader;
        private WaveOutEvent waveOut = new WaveOutEvent();
        public WaveOutEvent WaveOut
        {
            get
            {
                return waveOut;
            }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public NAudioPlayer() {}

        /// <summary>
        /// Verifies that the audio file exists and if it does, invokes the WaveOut API to play it.
        /// This can only play one audio file at a time. To play multiple, instantiate multiple NAudioPlayers.
        /// </summary>
        /// <param name="filePath">The path to the audio file, as a string.</param>
        public void Play(string filePath)
        {
            try
            {
                if (!File.Exists(filePath)) throw new Exception(string.Format("No such a file:{0}!", filePath));
                reader = new WaveFileReader(filePath);
                waveOut = new WaveOutEvent();
                waveOut.Init(reader);
                waveOut.PlaybackStopped += WaveOut_PlaybackStopped; ;       // Calls the WaveOut_PlaybackStopped method if playback is unexpectedly stopped.
                waveOut.Play();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }
        }
        
        /// <summary>
        /// Stops playback of the current wave sound.
        /// Forces the reader and WaveOutEvents to be disposed of immediately, rather than waiting for the Playbackstopped event.
        /// </summary>
        public void Stop()
        {
            if (waveOut.PlaybackState.Equals(PlaybackState.Playing))
            {
                waveOut.Stop();
                waveOut.Dispose();
                reader.Dispose();
            }
        }

        /// <summary>
        /// Pauses sound playback.
        /// </summary>
        public void Pause()
        {
            waveOut.Pause();
        }

        /// <summary>
        /// Unpauses sound playback. If the player is not currently paused, does nothing.
        /// </summary>
        public void Unpause()
        {
            if (waveOut.PlaybackState.Equals(PlaybackState.Paused))
            {
                waveOut.Play();
            }
        }
        /// <summary>
        /// Fires when the sound has finished playing, and cleans up any objects that may still be running.
        /// </summary>
        /// <param name="sender">Automatically generated by Visual Studio.</param>
        /// <param name="e">Automatically generated by Visual Studio.</param>
        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (sender != null) (sender as WaveOutEvent).Dispose();
            if (reader != null)
            {
                reader.Dispose();
                reader = null;
            }
        }
    }
}