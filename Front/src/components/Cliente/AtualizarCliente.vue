<template>
    <div id="cadastro-cliente">
      <h3>Atualizar Cliente</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Id</label>
              <input type="text" class="form-control" required placeholder="Id" v-model="this.$route.params.id" disabled>
          </div>
          <div>
              <label for="" class="form-label">Nome</label>
              <input type="text" class="form-control" required placeholder="Nome" v-model="cliente.nome">
          </div>
          <div>
              <label for="" class="form-label">Login</label>
              <input type="text" class="form-control" required placeholder="Login" v-model="cliente.login" disabled>
          </div>
          <div>
              <label for="" class="form-label">Senha</label>
              <input type="password" class="form-control" required v-model="cliente.senha">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="atualizarCliente">Cadastrar</button>
      </div>
    </div>
  </template>
  
  <script>
  import ClienteDataService from '../../services/ClienteDataService';
  export default {
      name: "AtualizarCliente",
      data(){
          return{
              cliente: {
              },
              updateCliente: {
                  nome: "",
                  senha: "",
                  login: ""
              }
          }
      },
      methods: {
          atualizarClienteData(){
              this.updateCliente.senha = this.cliente.senha
              this.updateCliente.nome = this.cliente.nome
              this.updateCliente.login = this.cliente.login
          },
          obterCliente(id){
              ClienteDataService.obterPorId(id)
                  .then((response) => {
                      console.log(response.data)
                      this.cliente = response.data;
                  })
          },
          atualizarCliente(){
              this.atualizarClienteData()
              ClienteDataService.atualizar(this.$route.params.id, this.updateCliente)
                  .then(() => {
                    this.$router.push({name: 'ListarCliente'})
                  })
          },
          
          
      },
      mounted(){
          this.obterCliente(this.$route.params.id)
      }
  }
  </script>
  
  <style>
  </style>