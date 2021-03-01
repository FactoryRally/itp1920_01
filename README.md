# Game Controller - 2.6.0

The Game Controller is an Web API controlling the logic/flow of one (or multiple) game sessions.

## Table of content

[TOC]

## Usage

> **IMPORTANT** As of the moment the server has no standalone executable
>                       The guide below shows how it will work as soon as the executable is available 

* Download the `robo-rally-server.exe` from the [release section](https://github.com/FactoryRally/game-controller/releases).

* Enable autostart (optional)

  * Windows
    * `WIN`+`R`  -> `shell:autostart`+`ENTER`
    * Hidden Autostart (no command line)
      * Move the `exe` directly into the opened folder
    * Visual Autostart
      * Download `autostart.bat` from the lastest release
      * Move `autostart.bat`  into the folder that opened
      * Close the explorer
      * `WIN`+`R`->`cmd /C "mkdir %homepath%\robo-rally-server & cd %homepath%\robo-rally-server && explorer ."`
      * Move the `exe` to the folder that opened
  * Linux (not docker)
    * Download and execute `enable-systemd-autostart.sh` 
    * This only works on systems using `systemd` as the name states 

  ### Config file 

  The config file defines the behaviour of the server.

  Location: `<user home>/robo-rally-server/settings.cfg`

  The path when using **docker** is `/game/settings.cfg`

  The file will be created with default values once the server is started the first time

  #### Values

  | Variable               | Description                                                  | type       | default                                                 |
  | ---------------------- | ------------------------------------------------------------ | ---------- | ------------------------------------------------------- |
  | *max-games*            | The number of games this server hosts (0 for unlimited; only allowed with `only one lobby`) | number     | 1                                                       |
  | *max-players*          | The maximum number of players per game                       | number     | 4                                                       |
  | *player-names-visible* | If true players can see each the name of each other          | boolean    | true                                                    |
  | *names*                | A list of names for the games                                | Text Array | ["Game 1",<br />"Game 2",<br />"Game 3",<br />"Game 4"] |
  | *password*             | The password needed to play (*null* for no password)         | text       | *null*                                                  |
  | *fill-with-bots*       | If true open places will be filled with bots                 | boolean    | false                                                   |
  | *open-map-repo*        | if true players can commit maps                              | boolean    | false                                                   |
  | *map-repo-location*    | The location where the maps are located (without / in front relative to exeuteable) | path       | maps                                                    |
  | only-one-lobby         | If this is set to true, only one joinable game at a time will exist.<br />This is useful for servers with many `max-games` |            |                                                         |

## Functionality

The complete logic is accessible via a HTTP Rest API. The core features are:

* Map repository to save maps
* Host for games

The complete documentation of the API is done in OAS<sup>[[1]](https://www.openapis.org)</sup> and found in `oas/game-engine.<version>.json`. There is a exported pdf called `documentation.pdf`. You can also use the HTML (requires internet) `rapidoc.html` version which looks better and is interactive. You also can create an up to date PDF by using `rapidoc-pdf.html` (also requires active internet connection)

### Events/Actions

Each event and action can only happen/execute at specific times (phases of the game)

#### Events

Events are things a client can react to. They are used to inform clients about changes. They are organized in Queues, where every player has his own queue and he can pop events from this queues and react to them.

The regarding issue can be found [here](https://github.com/FactoryRally/game-controller/issues/6).

#### Actions

Actions are the things players/clients can do with the game /interactions. An example for this would be laying down cards at programming phase

#### Graph

![A graph of all phases and their corresponding actions/events](D:\Users\Nils\Desktop\Schule\ITP\robot-rally\game-controller\documentation\game-cycle-events.png)

> The `UpgradeUsedEvent` is not entered in this graph to reduce retundancy but it can allways occur when `UseUpgrade`Action can be executed

#### Usage

[here](documentation/api-usage.md#Events & Updates)

## Structure

The implementation of the different phases is found in `Tgm.Roborally.Server.Engine.Phases` and the game cycle is found in `Tgm.Roborally.Server.Engine.GameThread`.

The core/root of the game logic is `Tgm.Roborally.Server.Engine.GameLogic`