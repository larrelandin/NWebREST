using System;
using System.Collections;
using Microsoft.SPOT;
using Microsoft.SPOT.Net.NetworkInformation;
using NetDuinoUtils.Utils;
using NWebREST.Web;

namespace Demo
{
    public class Program
    {
public static void Main()
{
    Debug.Print("NWebRest demo project");

    WebServerWrapper.InitializeWebEndPoints(new ArrayList
                                                {
                                                    new BasicPage(),
                                                    new ButtonWeb(),
                                                    new ParameterValues()
                                                });

    WebServerWrapper.StartWebServer();

    RunUtil.KeepRunning();
}
    }
}
