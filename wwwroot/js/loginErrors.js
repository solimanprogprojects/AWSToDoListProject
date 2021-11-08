function checkInput()
{
    var userNameFault = "Username must be 8 characters long. Please reenter.";
    var passwordFault = "Password must be 8 characters long. Please reenter";
    var userName = document.getElementById("userNameTxt").value;
    var password = document.getElementById("pwdTxt").value;
    if (userName.length < 8)
    {
        alert(userNameFault);
        return false;
    }
    if (password.length < 8)
    {
        alert(passwordFault);
        return false
    }
}