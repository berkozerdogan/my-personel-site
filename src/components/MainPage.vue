<script setup>
import { RouterLink, RouterView } from "vue-router";
</script>

<template>
  <div
    class="d-flex flex-column text-white bg-dark"
    style="position: fixed; top: 0; bottom: 0"
  >
    <RouterLink class="nav-link" to="/"
      ><svg class="bi me-2" width="16" height="16">
        <use xlink:href="#home"></use>
      </svg>
      Berk Özerdoğan</RouterLink
    >
    <div class="logo" style="justify-content: center">Full Stack Developer</div>

    <hr />
    <ul class="nav nav-pills flex-column mb-auto">
      <li>
        <RouterLink class="nav-link" to="/about"
          ><svg class="bi me-2" width="16" height="16">
            <use xlink:href="#home"></use>
          </svg>
          Ben Kimim ?</RouterLink
        >
      </li>
      <li>
        <RouterLink class="nav-link" to="/projects"
          ><svg class="bi me-2" width="16" height="16">
            <use xlink:href="#home"></use>
          </svg>
          Projelerim</RouterLink
        >
      </li>
      <li>
        <RouterLink class="nav-link" to="/contact"
          ><svg class="bi me-2" width="16" height="16">
            <use xlink:href="#home"></use>
          </svg>
          İletişim</RouterLink
        >
      </li>
      <li>
        <RouterLink class="nav-link" to="/comments"
          ><svg class="bi me-2" width="16" height="16">
            <use xlink:href="#home"></use>
          </svg>
          Fikirleriniz önemlidir ...</RouterLink
        >
      </li>
    </ul>
    <hr />
    <div class="social-icons">
      <a href="https://www.instagram.com/son4dakika/" target="_blank"
        ><i class="fa-brands fa-instagram-square"></i
      ></a>
      <a href="https://www.facebook.com/berkozerdogan/" target="_blank"
        ><i class="fa-brands fa-facebook-square"></i
      ></a>
      <a href="https://twitter.com/Berkozerdogan" target="_blank"
        ><i class="fa-brands fa-twitter-square"></i>
      </a>
      <a href="https://github.com/Wanudell" target="_blank"
        ><i class="fa-brands fa-github-square"></i
      ></a>
    </div>
  </div>
</template>
<script>
export default {};
</script>

<style scoped>
a {
  color: white;
}
.logo {
  display: flex;
}
.sidebar {
  position: fixed;
}
.social-icons {
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: space-evenly;
}
</style>
