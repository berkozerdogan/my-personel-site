<script setup>
import { RouterLink, RouterView } from "vue-router";
</script>

<template>
  <div class="row">
    <div class="col">
      <div>
        <HomePageVue />
      </div>
    </div>
  </div>
</template>

<style></style>
<script>
import HomePageVue from "./views/HomePage.vue";
export default {
  data() {
    return {};
  },
};
</script>
<!-- Col ayrımını dene. -->
<!-- STAR RATING, USER AUTHENTICATION, TOKEN eklenecek -->
<!-- Catpcha Eklemeyi öğren -->
