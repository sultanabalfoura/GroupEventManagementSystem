// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



document.getElementById("languageSwitchButton").addEventListener("click", function () {
            var currentLanguage = ""; 

    var newLanguage = currentLanguage === "en-US" ? "ar" : "en";

    window.location.href = '@Url.Action("SwitchLanguage", "Language")' + '?language=' + newLanguage;
        });
