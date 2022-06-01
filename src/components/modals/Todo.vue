<template>
  <div class="row">
    <div>
      <h1><span class="fa-solid fa-rectangle-list me-2 orange"></span>TODO</h1>
    </div>
    <div class="row">
      <div class="col-4">
        <div class="card-body">
          <h6>Todo List</h6>

          <textarea
            name=""
            id=""
            cols="39"
            rows="3"
            placeholder="Bugün ne yapmak istersiniz ?"
            v-model="work"
          ></textarea>

          <div class="mb-3">
            <label class="form-label">Önemlilik Derecesi:</label>
            <select
              class="form-select form-select-lg mb-3"
              aria-label=".form-select-lg example"
              v-model="importance"
            >
              <option :value="null" disabled>Select Age</option>
              <option
                v-for="importance in importanceLevel"
                :key="importance.id"
                :value="importance.title"
              >
                {{ importance.title }}
              </option>
            </select>
          </div>
          <div class="buttons">
            <button
              class="btn btn-primary me-2"
              @click="saveTodo"
              v-if="(work != null) & (importance != null)"
            >
              <span class="fa-solid fa-save"></span> Kaydet
            </button>
            <button class="btn btn-primary me-2" @click="clear">
              <span class="fa-solid fa-trash"></span> Temizle
            </button>
          </div>
        </div>
      </div>
      <div class="col-8">
        <h6 class="card-title mb-2">Aktif Liste</h6>
        <div class="card">
          <div class="card-body">
            <table class="table">
              <tr>
                <th>Yapılacak iş</th>
                <th>Önem Derecesi</th>
                <th>İşlem Saati</th>
                <th>ID</th>
                <th>Bitti mi ?</th>
              </tr>
              <tr v-for="todo in todoList">
                <td>
                  <span class="text-primary">{{ todo.work }}</span>
                </td>
                <td>
                  <span class="text-danger">{{ todo.importance }}</span>
                </td>
                <td>{{ todo.time }}</td>
                <td>{{ todo.id }}</td>
                <td>
                  <button @click="completed" class="btn btn-success">
                    <span class="fa-solid fa-check"></span> Tamamlandı
                  </button>
                </td>
                <td>
                  <button class="btn btn-danger" @click="delay(todo)">
                    <span class="fa-solid fa-check"></span> Ertele
                  </button>
                </td>
              </tr>
            </table>
            <div
              class="alert alert-danger"
              role="alert"
              v-if="todoList.length === 0"
            >
              Henüz kayıt mevcut değil !
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      todoList: [],
      work: null,
      importance: null,
      importanceLevel: [
        { id: 0, title: "Acil" },
        { id: 1, title: "1 gün içinde tamamlanmalı" },
        { id: 2, title: "1 hafta içinde tamamlanmalı" },
        { id: 3, title: "1 ay içinde tamamlanmalı" },
        { id: 4, title: "Geniş Zamanlı" },
      ],
    };
  },
  methods: {
    saveTodo() {
      let task = {
        work: this.work,
        importance: this.importance,
        time: new Date().toLocaleTimeString(),
        id: new Date().getTime(),
      };
      this.todoList.push(task);
      this.clear();
    },
    clear() {
      this.work = null;
      this.importance = null;
    },
    completed(id) {
      this.todoList.splice(id, 1);
    },
    delay(item) {
      item.importance = "Ertelendi";
    },
  },
};
</script>
