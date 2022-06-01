<template>
  <div class="container">
    <h1>3) Kullanıcı Paneli</h1>
    <div class="row">
      <div class="card">
        <div class="card-body">
          <h5 class="card-title">Kayıt Formu</h5>
          <div class="mb-3">
            <label class="form-label">Adınız:</label>
            <input type="text" class="form-control" v-model="name" />
          </div>
          <div class="mb-3">
            <label class="form-label">Doğum Tarihi:</label>
            <input type="Date" class="form-control" v-model="birthDate" />
          </div>
          <div class="mb-3">
            <label class="form-label">Cinsiyet:</label>
            <select class="form-control" v-model="gender">
              <option v-for="g in genders" :key="g.id" :value="g.id">
                {{ g.text }}
              </option>
            </select>
          </div>
          <button class="btn btn-primary me-2" @click="saveUser">
            <span class="fa-solid fa-save"></span> Kaydet
          </button>
          <button class="btn btn-danger" @click="clear">
            <span class="fa-solid fa-trash"></span> Temizle
          </button>
        </div>
      </div>
    </div>
    <div class="col">
      <div class="card">
        <div class="card-body">
          <h5 class="card-title">Kayıt Listesi</h5>
          <table class="table">
            <tr>
              <th>Adı Soyadı</th>
              <th>Yaşı</th>
              <th>Id Numarası</th>
              <th>Cinsiyet Simgesi</th>
            </tr>
            <tr v-for="p in people" :key="p.id">
              <td>{{ p.name }}</td>
              <td>{{ p.birthDate }}</td>
              <td>{{ p.id }}</td>
              <td>
                <span class="fa-solid" :class="showGender(p.gender)"></span>
              </td>
              <td><button @click="deleteUser">Sil</button></td>
            </tr>
          </table>

          <div
            class="alert alert-warning"
            role="alert"
            v-if="people.length === 0"
          >
            Henüz kayıt mevcut değil !
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
      people: [],
      name: null,
      birthDate: null,

      gender: null,
      genders: [
        {
          id: 0,
          text: "Kadın",
        },
        { id: 1, text: "Erkek" },
      ],
    };
  },
  methods: {
    clear() {
      this.name = null;
      this.birthDate = null;
      this.gender = null;
    },
    saveUser() {
      let person = {
        name: this.name,
        id: new Date().getTime(),
        birthDate:
          new Date().getFullYear() - new Date(this.birthDate).getFullYear(),
        gender: this.gender,
      };
      this.people.push(person);
      this.clear();
    },
    showGender(gender) {
      return gender === 0 ? "fa-female pink" : "fa-male blue";
    },
    deleteUser(id) {
      this.people.splice(id, 1);
    },
  },
};
</script>
<style>
.pink {
  color: rgb(209, 57, 176);
}
.blue {
  color: blue;
}
</style>
