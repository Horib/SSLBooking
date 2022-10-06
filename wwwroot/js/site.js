// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const html = document.querySelector("html")
if (localStorage.theme) {
    html.classList.add(localStorage.theme)
} else {
    localStorage.theme = 'light'
    html.classList.add(localStorage.theme)
}

const darkBtn = document.querySelector("#theme-btn");
darkBtn.addEventListener("click", () => {
    const oldTheme = localStorage.theme
    localStorage.theme = localStorage.theme === "dark" ? 'light' : "dark";

    html.classList.remove(oldTheme)
    html.classList.add(localStorage.theme)
})
