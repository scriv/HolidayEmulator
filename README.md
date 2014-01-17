# Holiday Emulator

This is a basic .NET/Windows implementation of a [Moore's Cloud Holiday](http://www.moorescloud.com/) emulator. I created this so that there is a simple way to develop against Holiday for .NET/Windows developers with no need for Python runtime knowledge as needed by [Holideck](https://github.com/moorescloud/holideck).

Run HolidayEmulator.exe as Administrator and you will be able to send requests to localhost:2512 as you would with normal Holiday devices, for example:

```
PUT http://localhost:2512/iotas/0.1/device/moorescloud.holiday/localhost/setlights

{ "lights": [ "#FFFFFF", "#FFFFFF", "#FFFFFF", "#FFFFFF", "#FFFFFF",
"#FF0000", "#00FF00", "#0000FF", "#FFFFFF", "#000000",
"#FF0000", "#00FF00", "#0000FF", "#FFFFFF", "#000000",
"#FF0000", "#00FF00", "#0000FF", "#FFFFFF", "#000000",
"#FF0000", "#00FF00", "#0000FF", "#FFFF00", "#000000",
"#FF0000", "#00FF00", "#0000FF", "#FFFFFF", "#000000",
"#FF0000", "#00FF00", "#0000FF", "#FFFFFF", "#000000",
"#FF0000", "#00FF00", "#0000FF", "#FFFFFF", "#000000",
"#FF0000", "#00FF00", "#0000FF", "#FFFFFF", "#000000",
"#FF0000", "#00FF00", "#0000FF", "#FFFFFF", "#FFFFFF" ] }
```

![ScreenShot](https://raw2.github.com/scriv/HolidayEmulator/master/screenshot.png)
