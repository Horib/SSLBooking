// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// On page load or when changing themes, best to add inline in `head` to avoid FOUC
if (localStorage.theme === 'dark' || (!('theme' in localStorage) && window.matchMedia('(prefers-color-scheme: dark)').matches)) {
    document.documentElement.classList.add('dark')
} else {
    document.documentElement.classList.remove('dark')
}

// Whenever the user explicitly chooses light mode
localStorage.theme = 'light'

// Whenever the user explicitly chooses dark mode
localStorage.theme = 'dark'

// Whenever the user explicitly chooses to respect the OS preference
localStorage.removeItem('theme')

const darkBtn = document.querySelector("#dark-btn");
darkBtn.addEventListener("click", () => {
    const remove = localStorage.theme
    localStorage.theme = 'dark'

    changeTheme(localStorage.theme, remove)
})
const lightBtn = document.querySelector("#light-btn");
lightBtn.addEventListener("click", () => {
    const remove = localStorage.theme
    localStorage.theme = 'light'

    changeTheme(localStorage.theme, remove)
})

function changeTheme(add, remove) {
    const html = document.querySelector("html")
    html.classList.remove(remove)
    html.classList.add(add)
}
