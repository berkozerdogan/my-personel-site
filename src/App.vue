<script setup>
import mainPage from "./components/MainPage.vue";
import { RouterLink, RouterView } from "vue-router";
// import VueMq from "vue-mq";

// Vue.use(VueMq, {
//   breakpoints: {
//     mobile: 450,       ///////Responsive framework ü ekleyerek denedim.
//     tablet: 900,
//     laptop: 1250,
//     desktop: Infinity,
//   },
// });
</script>

<template>
  <mainPage />

  <RouterView />
</template>

<style></style>

<!-- Col ayrımını dene. -->
<!-- STAR RATING, USER AUTHENTICATION, TOKEN eklenecek -->
<!-- Catpcha Eklemeyi öğren -->
