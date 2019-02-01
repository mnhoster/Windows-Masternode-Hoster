mnhoster.com

Windows Masternode Hoster - Tool For Hosting Masternodes At Windows System

It Doesnt Need Any Special Wallet, It Works With QT Wallet.
It Is Hot Node - Cold Wallet Setup (same as ubuntu setups)
Windows VPS Not Needed but Recommended.
Supporting All Masternode Coins (i suppose)
Supporting Multiple Masternodes For Same Coin (i am sure)


Requirements
If you going to use this tool at your own pc (your own wallet and masternode host wallet/s at same pc) you need to edit your $coinname.conf file, you must change/add 'listen=0' to your $coinname.conf file.
WorkingDirectory must not contains spaces. Use 'D:\MasternodeHosterWorkingDirectory' recomended
Your MasternodePorts must be forwarded. (as usual)


How is it working?

This tool copies your masternode's wallet and dash-cli.exe (For RPC Communication) to working directory and builds $coinname.conf file with your input values.
You can copy your blockchain folders (blocks,chainstate,sporks etc.) to workingdirectory\$coinname folder or just wait qt wallet for downloading blockchain files.
And when you start your masternode it links "datadir" and "conf" values to workingdirectory\$coinname\$coinname.conf file. 
This way you can host your masternodes at windows and if you change your 'masternode port', 'rpc port' and 'coinname' for every instance masternode setup, and you can start multiple masternodes for same coin.

Working On:
I am trying to building a platform for checking masternode statuses and getting simple informations. It will be on http://mnhoster.com]mnhoster.com
Early Builds will be on https://mnhoster.com/earlybuilds/]mnHoster Early Builds

2019.02.02
New: autoget rpcport and masternodeport from qt wallet.
New: Easy uPnP port forwarding option for selected ports.

Downloads

Early Builds Repo : https://mnhoster.com/earlybuilds/ 


![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/1.JPG)

![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/2.JPG)

![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/2a.JPG)

![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/2b.JPG)

![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/3.JPG)

![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/4.JPG)

![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/5.JPG)

![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/6.JPG)

![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/7.JPG)

![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/8.JPG)

![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/9.JPG)

![alt text](https://raw.githubusercontent.com/mnhoster/Windows-Masternode-Hoster/master/10.JPG)

I am trying to building a platform for checking masternode statuses and getting simple informations. It will be on http://mnhoster.com]mnhoster.com

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
