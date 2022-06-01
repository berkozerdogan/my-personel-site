<template>
  <div class="container mt-3">
    <h1>Şarkım</h1>
    <YouTube
      src="https://www.youtube.com/watch?v=2AnVWHNOnjs&ab_channel=AkustikMakam"
      @ready="onReady"
      ref="youtube"
    />
    <div class="search">
      <input type="field" />
      <i class="fas fa-search"></i>
    </div>
  </div>
</template>
<script>
import { defineComponent } from "vue";
import YouTube from "vue3-youtube";

export default defineComponent({
  components: { YouTube },
  methods: {
    onReady() {
      this.$refs.youtube.playVideo();
    },
  },
});
</script>

<style>
.search i {
  margin-left: 5px;
  color: white;
  background-color: gray;
}
</style>
