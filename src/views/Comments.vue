<template>
  <div class="container mb-3 mt-3">
    <button
      type="button"
      class="btn btn-primary"
      data-bs-toggle="modal"
      data-bs-target="#commentModal"
    >
      Yorumlarınız ?
    </button>

    <div
      class="modal fade"
      id="commentModal"
      tabindex="-1"
      aria-labelledby="commentModalLabel"
      aria-hidden="true"
    >
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="commentModalLabel">Yeni Yorum</h5>
            <button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-label="Close"
            ></button>
          </div>
          <div class="modal-body">
            <form>
              <div class="mb-3">
                <label for="recipient-name" class="col-form-label"
                  >Yorum Sahibi</label
                >
                <input
                  type="text"
                  class="form-control"
                  id="recipient-name"
                  v-model="userName"
                />
              </div>
              <div class="mb-3">
                <label for="message-text" class="col-form-label"
                  >Mesajınız</label
                >
                <textarea
                  class="form-control"
                  id="message-text"
                  v-model="message"
                ></textarea>
              </div>
              <div>
                <span>&star;</span>
                <span>&star;</span>
                <span>&star;</span>
                <span>&star;</span>
                <span>&star;</span>
                <hr />
              </div>

              <button
                type="button"
                @click="saveComment"
                data-bs-dismiss="modal"
              >
                Yorumu Kaydet
              </button>
            </form>
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class="container comment">
    <div
      class="col"
      style="width: 500px, height:250px"
      v-for="message in comments"
    >
      <div class="card text-white bg-dark mb-3 mt-3" style="max-width: 40rem">
        <div class="card-header bg-primary" style="background-color: #d62828">
          {{ message.userName }}
        </div>
        <div class="card-body">
          <h5 class="card-title">{{ message.message }}</h5>
          <p class="card-text">
            {{ message.commentDate }}
          </p>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      userName: null,
      message: null,
      comments: [
        {
          userName: "İsmail Özerdoğan",
          message: "Çalışmaktan hiç korkma, her zaman dene ve yorulma !",
          commentDate: new Date().toLocaleTimeString(),
        },
        {
          userName: "Münire Özerdoğan",
          message:
            "Bugün göğüs gerdiğin her acın seni yarın daha güçlü kılacak.",
          commentDate: new Date().toLocaleTimeString(),
        },
        {
          userName: "Halenur Şahin",
          message: "<3",
          commentDate: new Date().toLocaleTimeString(),
        },
      ],
    };
  },
  methods: {
    saveComment() {
      let comment = {
        userName: this.userName,
        message: this.message,
        commentDate: new Date().toLocaleTimeString(),
      };
      this.comments.push(comment);
      this.clear();
    },
    clear() {
      this.userName = null;
      this.message = null;
    },
  },
};
</script>
<style scoped>
.comment {
  display: flex;
  column-count: 2;
  align-items: center;
  text-align: center;
  flex-direction: column;
  overflow: auto;
  width: 100%;
  height: 700px;
}
</style>
