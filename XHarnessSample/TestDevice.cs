﻿using Microsoft.DotNet.XHarness.TestRunners.Common;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XHarnessSample
{
	class TestDevice : IDevice
	{
		public string BundleIdentifier => AppInfo.PackageName;

		public string UniqueIdentifier => Guid.NewGuid().ToString("N");

		public string Name => DeviceInfo.Name;

		public string Model => DeviceInfo.Model;

		public string SystemName => DeviceInfo.Platform.ToString();

		public string SystemVersion => DeviceInfo.VersionString;

		public string Locale => CultureInfo.CurrentCulture.Name;
	}
}
