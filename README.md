IonicProxyAuth: Utility for troubleshooting proxy problems with authentication using the Ionic Framework

Requirements:
<a href="https://nodejs.org">NodeJs</a> and <a href="https://www.npmjs.com/package/proxy-login-automator">proxy-login-automator</a> module.

Parameters:
<li>Corporate Proxy: Corporate proxy thats require authenticaton.
<li>Proxy User: Corporate proxy user name.
<li>Proxy Password: Corporate proxy password.
<li>Local Proxy Port: Local port to listen proxy.
<li>Status: Current status of Local listen proxy.

Commands:
<li>Apply: Apply/change current configuration settings.
<li>Check Module: Check if module proxy-login-automator is installed. If not, run the command npm install -g proxy-login-automator.
<li>Start Local Proxy: Start/Stop the Local proxy using current configuration.
<li>Clear Log: Clear the current Status textarea log from window.
<li>Show Env/cmd: Show enviroment variables for ionic proxy configuration, copy to clipboard and open command prompt to paste and run ionic commands.

How it Works: Starts a Local proxy that not require authentication and send http/s request to authenticated corporate proxy, using your corporate credencials, without require additional configurations to your Ionic/NodeJs scripts/modules.
