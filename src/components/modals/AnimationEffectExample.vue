<template>
  <div class="container">
    <h1>1) Animasyon Efekti</h1>
    <div>
      <div class="col project-1">
        <div class="divMain">
          <div class="divEyes">
            <div class="divEyeBall"></div>
          </div>
          <div class="divEyes">
            <div class="divEyeBall"></div>
          </div>
        </div>
        <div class="TEXTING">
          <span class="textDesign">DEADPOOL</span>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {};
</script>

<style>
.project-1 {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  background-color: black;
}

.divMain {
  background-color: rgb(255, 0, 0);
  height: 105px;
  width: 100px;
  display: flex;
  align-items: center;
  border-radius: 50%;
  animation: float 5s ease-in-out infinite;
}

.divEyes {
  margin: 1px;
  display: flex;
  align-items: center;
  justify-content: space-evenly;
  background-color: black;
  border-radius: 50%;
  width: 50px;
  height: 50px;
  animation-delay: 10s;
}
.divEyeBall {
  display: flex;
  align-items: center;
  justify-content: space-evenly;
  background: white;
  width: 20px;
  height: 10px;
  border-radius: 50%;
}

.TEXTING {
  margin-top: 200px;
  display: flex;
  align-items: center;
  text-align: center;
  color: rgba(255, 0, 0, 0.6);
  width: 270px;
  height: 60px;
  font-size: 50px;
}
.textDesign {
  background-color: black;
  border: 3px solid white;
}

@keyframes float {
  0% {
    transform: translateY(0) translateX(125px);
  }
  25% {
    transform: translateY(125px) translateX(125px);
  }
  50% {
    transform: translateX(-125px) translateY(125px);
  }
  75% {
    transform: translateY(0px) translateX(-125px);
  }
  100% {
    transform: translateY(0px) translateX(125px);
  }
}
</style>
