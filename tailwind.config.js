/** @type {import('tailwindcss').Config} */
module.exports = {
    darkMode: ['class', '[data-mode="dark"]'],
    content: [
        './Views/**/*.cshtml'
    ],
    theme: {
        extend: {},
    },
    plugins: [
        require('@tailwindcss/forms'),
        require('@tailwindcss/typography')
    ],
}
