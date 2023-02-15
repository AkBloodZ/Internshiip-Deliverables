const navSlide = () => {
  const burger = document.querySelector(".burger");
  const nav = document.querySelector(".nav-links");

  burger.addEventListener("click", () => {
    nav.classList.toggle("nav-active");
  });
};

navSlide();

fetch('https://newsapi.org/v2/everything?q=tesla&from=2023-01-14&sortBy=publishedAt&apiKey=07ddaf77edfc458eadaa801a7f21bdb2')
  .then(response => response.json())
  .then(data => {
    const container = document.getElementById('data-container');
    data.forEach(item => {
      const element = document.createElement('div');
      element.innerText = item.name;
      container.appendChild(element);
    });
  })
  .catch(error => console.error(error));
