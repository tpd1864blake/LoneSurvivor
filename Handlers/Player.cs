using System.Collections.Generic;
using System;
using Exiled.API.Features;
using EPlayer = Exiled.API.Features.Player;
using EPlugin = LoneSurvivor.SurvivorPlugin;
using Exiled.Events.EventArgs;
using MEC;
using UnityEngine;

namespace LoneSurvivor.Handlers
{
    class Player
    {
        public void OnDisconnect(LeftEventArgs ev)
        {
            RemovePlayer(ev.Player);
        }

        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            RemovePlayer(ev.Player);
        }
        public static void RemovePlayer(EPlayer player)
        {
            switch (player.Team)
            {
                case Team.CDP:
                    int cdnum = 0;
                    EPlayer cdlast = null;
                    foreach (EPlayer p in EPlayer.List)
                    {
                        if (p.Team == Team.CDP)
                        {
                            cdnum++;
                            cdlast = p;
                        }
                    }
                    if (cdnum == 1 && cdlast != null)
                    {
                        int index = new System.Random().Next(EPlugin.Instance.Config.ClassDMessages.Count);
                        cdlast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.ClassDMessages[index]);
                    }
                    break;
                case Team.RSC:
                    int scnum = 0;
                    EPlayer sclast = null;
                    foreach (EPlayer p in EPlayer.List)
                    {
                        if (p.Team == Team.CDP)
                        {
                            scnum++;
                            sclast = p;
                        }
                    }
                    if (scnum == 1 && sclast != null)
                    {
                        int index = new System.Random().Next(EPlugin.Instance.Config.ScientistMessages.Count);
                        sclast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.ScientistMessages[index]);
                    }
                    break;
                case Team.MTF:
                    int mtfnum = 0;
                    EPlayer mtflast = null;
                    foreach (EPlayer p in EPlayer.List)
                    {
                        if (p.Team == Team.CDP)
                        {
                            mtfnum++;
                            mtflast = p;
                        }
                    }
                    if (mtfnum == 1 && mtflast != null)
                    {
                        int index = new System.Random().Next(EPlugin.Instance.Config.MTFMessages.Count);
                        mtflast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.MTFMessages[index]);
                    }
                    break;
                case Team.CHI:
                    int chinum = 0;
                    EPlayer chilast = null;
                    foreach (EPlayer p in EPlayer.List)
                    {
                        if (p.Team == Team.CDP)
                        {
                            chinum++;
                            chilast = p;
                        }
                    }
                    if (chinum == 1 && chilast != null)
                    {
                        int index = new System.Random().Next(EPlugin.Instance.Config.ChaosMessages.Count);
                        chilast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.ChaosMessages[index]);
                    }
                    break;
                case Team.SCP:
                    int scpnum = 0;
                    EPlayer scplast = null;
                    foreach (EPlayer p in EPlayer.List)
                    {
                        if (p.Team == Team.CDP)
                        {
                            scpnum++;
                            scplast = p;
                        }
                    }
                    if (scpnum == 1 && scplast != null)
                    {
                        int index = new System.Random().Next(EPlugin.Instance.Config.ScpMessages.Count);
                        scplast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.ScpMessages[index]);
                    }
                    break;
                case Team.TUT:
                    int tutnum = 0;
                    EPlayer tutlast = null;
                    foreach (EPlayer p in EPlayer.List)
                    {
                        if (p.Team == Team.CDP)
                        {
                            tutnum++;
                            tutlast = p;
                        }
                    }
                    if (tutnum == 1 && tutlast != null)
                    {
                        int index = new System.Random().Next(EPlugin.Instance.Config.TutorialMessages.Count);
                        tutlast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.TutorialMessages[index]);
                    }
                    break;
                case Team.RIP:
                    int ripnum = 0;
                    EPlayer riplast = null;
                    foreach (EPlayer p in EPlayer.List)
                    {
                        if (p.Team == Team.CDP)
                        {
                            ripnum++;
                            riplast = p;
                        }
                    }
                    if (ripnum == 1 && riplast != null)
                    {
                        int index = new System.Random().Next(EPlugin.Instance.Config.SpectatorMessages.Count);
                        riplast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.SpectatorMessages[index]);
                    }
                    break;
            }
        }
    }
}
