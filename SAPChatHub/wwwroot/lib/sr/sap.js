

function httpGet(theUrl) {
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open("GET", theUrl, false); // false for synchronous request
    xmlHttp.send(null);
    return xmlHttp.responseText;
}

function register() {
    var result = httpGet("https://localhost:44316/v1/auth/register");
    console.log(result);
}

function CIDRegister(cid) {
    var result = httpGet("https://localhost:44316/v1/auth/CIDRegister?cid=" + cid);
    console.log(result);
}

var chatBox = '<div class="container">' +
    '<input type="text" id="message" />' +
    '<input type="button" id="sendmessage" value="Send" />' +
    '<ul id="discussion"></ul> </div> </div>';
document.write(chatBox);
var cid = "";
var cc = "<script src=\"https://localhost:44316/lib/sr/signalr.js\"><\/script>";
document.write(cc);
var sc = "<script  src=\"https://localhost:44316/lib/sr/connection.js?v=2\"><\/script>";
document.write(sc);
var rc = "<script  src=\"https://localhost:44316/lib/sr/registration.js\"><\/script>";
document.write(rc);



