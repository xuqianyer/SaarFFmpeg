﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Saar.FFmpeg.CSharp;
using Saar.FFmpeg.Internal;
using System.Diagnostics;

namespace SaarFFmpeg.EncodeAudio {
	class Program {
		unsafe static void Main(string[] args) {
			using (var reader = new MediaReader(@"Z:\Crazy Berry-liar lips.mp3")) {
				var decoder = reader.Decoders.OfType<AudioDecoder>().First();
				var frame = new AudioFrame();
				using (var writer = new MediaWriter(@"Z:\output.mp3").AddAudio(decoder.OutFormat, BitRate._64Kbps).Initialize()) {
					var enc = writer.Encoders[0] as AudioEncoder;
					while (reader.NextFrame(frame, decoder.StreamIndex)) {
						Console.Write($"\rframes: {enc.InputFrames}, time: {enc.InputTimestamp}");
						writer.Write(frame);
					}
					Console.WriteLine($"\rframes: {enc.InputFrames}, time: {enc.InputTimestamp}");
				}
			}
		}
	}
}
