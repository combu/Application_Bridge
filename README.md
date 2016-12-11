# Application_Bridge
ApplicationBridgeは諸事情でGameLancher下のパスでは実行できず、ある決まったパスからでしか実行できないプログラム(Processingなど)をGameLancherで起動するためのアプリケーションです。<br>
仕組みは簡単で、GameLancherでこのApplicationBridgeを呼び出し、ApplicationBridgeからある決まったパスからでしか実行できないプログラム(Processingなど)を呼び出し実行させるというものです。<br>
<br>
1, ApplicationBridge.exeと同じ階層にpath.txtを作成してください。(path.txtは自動生成されません。)<br>
2, path.txtには呼び出したいアプリケーションの"絶対パス"を書いてください。<br>
3, ApplicationBridge.exeを実行してください。<br>
