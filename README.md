[center][size=20pt]mnhoster.com[/size]

Windows Masternode Hoster - Tool For Hosting Masternodes At Windows System

It Doesnt Need Any Special Wallet, It Works With QT Wallet.
It Is Hot Node - Cold Wallet Setup (same as ubuntu setups)
Windows VPS Not Needed but Recommended.
Supporting All Masternode Coins (i suppose)
Supporting Multiple Masternodes For Same Coin (i am sure)


[color=red][font=Verdana][b]Requirements
If you going to use this tool at your own pc (your own wallet and masternode host wallet/s at same pc) you need to edit your $coinname.conf file, you must change/add 'listen=0' to your $coinname.conf file.
WorkingDirectory must not contains spaces. Use 'D:\MasternodeHosterWorkingDirectory' recomended
Your MasternodePorts must be forwarded. (as usual)[/b][/font][/color]


How is it working?

This tool copies your masternode's wallet and dash-cli.exe (For RPC Communication) to working directory and builds $coinname.conf file with your input values.
You can copy your blockchain folders (blocks,chainstate,sporks etc.) to workingdirectory\$coinname folder or just wait qt wallet for downloading blockchain files.
And when you start your masternode it links "datadir" and "conf" values to workingdirectory\$coinname\$coinname.conf file. 
This way you can host your masternodes at windows and if you change your 'masternode port', 'rpc port' and 'coinname' for every instance masternode setup, and you can start multiple masternodes for same coin.

[color=red]Working On: [/color]
I am trying to building a platform for checking masternode statuses and getting simple informations. It will be on [url=http://mnhoster.com]mnhoster.com[/url]
Early Builds will be on [url=https://mnhoster.com/earlybuilds/]mnHoster Early Builds[/url]

2019.02.02
[color=red]New: [/color] autoget rpcport and masternodeport from qt wallet.
[color=red]New: [/color] Easy uPnP port forwarding option for selected ports.

[size=18pt][color=red]Downloads[/color][/size]

[size=15pt][url=https://mnhoster.com/earlybuilds/]Early Builds Repo[/url][/size]

[size=15pt][url=https://github.com/mnhoster/Windows-Masternode-Hoster/releases/tag/2019.02.02]Github[/url][/size]

[center][img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/1.JPG[/img]

[img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/2.JPG[/img]

[img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/2a.JPG[/img]

[img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/2b.JPG[/img]

[img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/3.JPG[/img]

[img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/4.JPG[/img]

[img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/5.JPG[/img]

[img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/6.JPG[/img]

[img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/7.JPG[/img]

[img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/8.JPG[/img]

[img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/9.JPG[/img]

[img]https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/10.JPG[/img][/center]

I am trying to building a platform for checking masternode statuses and getting simple informations. It will be on [url=http://mnhoster.com]mnhoster.com [/url]

I Successfully Run 3 Masternodes At 1 GB RAM Free Tier VPS. That means 5 dollar/month for 3 Masternodes. 0,055$/day for 1 Masternode. (i have only 3 masternodes. need feedback for price / performance)
You Can Run This Tool at Your PC But Eventually You Will Restart Your PC, So I Recommend to [Suspicious link removed]. But If You Are A ROI Hunter, This Tool May Help You.

Seriously This Tool Deserves Monthly Subscription around 5$/month ;D Maybe You Stop Using Masternode Platforms With Help Of This Tool, So You Make Some Donations To Me?

BTC: bc1qv49dztqqgg87h5w5mz032uhhu5zjjsg3nkkp5w
USDT: 1DA6hXiuCwPPrDeR3HDUqNgBukdaLSutC9
LTC: MVteRn4pwh3rK2Xx5gVkG4buKWCLXvTzHL
ETC: 0xA19b88aCa06fDDAFf83Cc3A23b5e5a22d04911a3
ETH: 0x94ac3e1056597d8aaee2230873e682b23b1f43a2
DOGE: DP6CvuiFG4mm2DVPRh2uLTVcJEMEzVeuRa
VERGE: DSfyV9ZSJYZqw3nU12Nvo2q7KagXwXSFCf[/center]
