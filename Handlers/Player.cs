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
                        if (EPlugin.Instance.Config.UseHints != false)
                        {
                            cdlast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.ClassDMessages[index]);
                        } else
                        {
                            cdlast.ShowHint($"\n\n\n\n{EPlugin.Instance.Config.ClassDMessages[index]}", EPlugin.Instance.Config.BroadcastDuration);
                        }
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
                        if (EPlugin.Instance.Config.UseHints != false)
                        {
                            sclast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.ScientistMessages[index]);
                        }
                        else
                        {
                            sclast.ShowHint($"\n\n\n\n{EPlugin.Instance.Config.ScientistMessages[index]}", EPlugin.Instance.Config.BroadcastDuration);
                        }
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
                        if (EPlugin.Instance.Config.UseHints != false)
                        {
                            mtflast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.MTFMessages[index]);
                        }
                        else
                        {
                            mtflast.ShowHint($"\n\n\n\n{EPlugin.Instance.Config.MTFMessages[index]}", EPlugin.Instance.Config.BroadcastDuration);
                        }
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
                        if (EPlugin.Instance.Config.UseHints != false)
                        {
                            chilast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.ChaosMessages[index]);
                        }
                        else
                        {
                            chilast.ShowHint($"\n\n\n\n{EPlugin.Instance.Config.ChaosMessages[index]}", EPlugin.Instance.Config.BroadcastDuration);
                        }
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
                        if (EPlugin.Instance.Config.UseHints != false)
                        {
                            scplast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.ScpMessages[index]);
                        }
                        else
                        {
                            scplast.ShowHint($"\n\n\n\n{EPlugin.Instance.Config.ScpMessages[index]}", EPlugin.Instance.Config.BroadcastDuration);
                        }
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
                        if (EPlugin.Instance.Config.UseHints != false)
                        {
                            tutlast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.TutorialMessages[index]);
                        }
                        else
                        {
                            tutlast.ShowHint($"\n\n\n\n{EPlugin.Instance.Config.TutorialMessages[index]}", EPlugin.Instance.Config.BroadcastDuration);
                        }
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
                        if (EPlugin.Instance.Config.UseHints != false)
                        {
                            riplast.Broadcast(EPlugin.Instance.Config.BroadcastDuration, EPlugin.Instance.Config.SpectatorMessages[index]);
                        }
                        else
                        {
                            riplast.ShowHint($"\n\n\n\n{EPlugin.Instance.Config.SpectatorMessages[index]}", EPlugin.Instance.Config.BroadcastDuration);
                        }
                    }
                    break;
            }
        }
    }
}
