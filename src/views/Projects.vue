<template>
  <div class="selam buttons">
    <!-- Button trigger modal -->
    <!-- <button
      type="button"
      class="btn btn-primary"
      data-bs-toggle="modal"
      data-bs-target="#exampleModal"    ///1. numaralı yöntem Click event'i olmadan.
      
    >
      Launch demo modal
    </button> -->

    <button class="btn btn-success" @click="openProject1">Proje 1</button>
    <!-- Modal -->
    <div
      class="modal fade"
      id="exampleModal"
      tabindex="-1"
      aria-labelledby="exampleModalLabel"
      aria-hidden="true"
    >
      <div class="modal-dialog modal-xl">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">
              Animasyon Efekti Örneği
            </h5>
            <button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-label="Close"
            ></button>
          </div>
          <div class="modal-body"><Animation /></div>
          <div class="modal-footer">
            <button
              type="button"
              class="btn btn-secondary"
              data-bs-dismiss="modal"
            >
              Close
            </button>
          </div>
        </div>
      </div>
    </div>

    <button class="btn btn-primary mb-3 mt-3" @click="openProject2">
      Proje 2
    </button>
    <!-- Modal -->
    <div
      class="modal fade"
      id="exampleModal1"
      tabindex="-1"
      aria-labelledby="exampleModal1Label"
      aria-hidden="true"
    >
      <div class="modal-dialog modal-xl">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModal1Label">Todo Uygulaması</h5>
            <button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-label="Close"
            ></button>
          </div>
          <div class="modal-body"><Todo /></div>
          <div class="modal-footer">
            <button
              type="button"
              class="btn btn-secondary"
              data-bs-dismiss="modal"
            >
              Close
            </button>
          </div>
        </div>
      </div>
    </div>

    <button class="btn btn-danger" @click="openProject3">Proje 3</button>
    <!-- Modal -->
    <div
      class="modal fade"
      id="userPage"
      tabindex="-1"
      aria-labelledby="exampleModalLabel"
      aria-hidden="true"
    >
      <div class="modal-dialog modal-xl">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">
              Animasyon Efekti Örneği
            </h5>
            <button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-label="Close"
            ></button>
          </div>
          <div class="modal-body"><ProjectUser /></div>
          <div class="modal-footer">
            <button
              type="button"
              class="btn btn-secondary"
              data-bs-dismiss="modal"
            >
              Close
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import Animation from "../components/modals/AnimationEffectExample.vue";
import Todo from "../components/modals/Todo.vue";
import ProjectUser from "../components/modals/ProjectUser.vue";

export default {
  data() {
    return {
      myModal: null,
      myModal1: null,
      projectUser: null,
    };
  },
  components: {
    Animation,
    Todo,
    ProjectUser,
  },
  mounted() {
    this.myModal = new bootstrap.Modal(document.getElementById("exampleModal"));
    this.myModal1 = new bootstrap.Modal(
      document.getElementById("exampleModal1")
    );
    this.projectUser = new bootstrap.Modal(document.getElementById("userPage"));
  },
  methods: {
    openProject1() {
      this.myModal.show();
    },
    openProject2() {
      this.myModal1.show();
    },
    openProject3() {
      this.projectUser.show();
    },
  },
};
</script>
<style scoped>
.buttons {
  display: flex;
  flex-direction: column;
  justify-content: center;
}
</style>
