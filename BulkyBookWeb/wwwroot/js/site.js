// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Function to change copy year dynamically
const copyYear = document.querySelector('.copy-year');

const changeCopyYear = function (container) {
    const today = new Date().getFullYear();
    container.textContent = today;
}

changeCopyYear(copyYear);