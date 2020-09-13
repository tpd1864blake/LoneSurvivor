# LoneSurvivor
[![forthebadge](https://forthebadge.com/images/badges/gluten-free.svg)](https://forthebadge.com) [![forthebadge](https://forthebadge.com/images/badges/does-not-contain-msg.svg)](https://forthebadge.com) [![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)

LoneSurvivor is a plugin for SCP: SL. It requires EXILED 2.1.3+ to download.
LoneSurvivor makes it so when you're the last member on your team, you get a customizable broadcast telling you so. Every broadcast is fully customizable in the config.yml file.
## Default Configurations
```yml
lone_survivor:
  # Is the plugin enabled?
  is_enabled: true
  # How long should the message last?
  broadcast_duration: 10
  # Possible messages Class-D can see when they're the last alive
  class_d_messages:
  - You are the last Class-D alive!
  # Possible messages Scientists can see when they're the last alive
  scientist_messages:
  - You are the last Scientist alive!
  # Possible messages MTF can see when they're the last alive
  m_t_f_messages:
  - You are the last MTF alive!
  # Possible messages Chaos Insurgency can see when they're the last alive
  chaos_messages:
  - You are the last Chaos Insurgent alive!
  # Possible messages SCPs can see when they're the last alive
  scp_messages:
  - You are the last SCP alive!
  # Possible messages Tutorials can see when they're the last alive, for plugins like Serpent's Hand
  tutorial_messages: []
  # Possible messages Spectators can see when they're the only one dead. idk maybe you have a use :/
  spectator_messages: []
```
