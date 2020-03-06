import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/UsuarioServico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class LoginComponent implements OnInit {

  public usuario;
  public returnUrl: string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private usuarioServico: UsuarioServico) {
    
  }

  ngOnInit(): void {
    this.usuario = new Usuario();
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
  }

  public entrar() {
    //Observable
    //O UsuarioServico(organizador) exige que os interessados no
    //produto(resultado dos métodos???) que ele oferece se inscrevam
    this.usuarioServico.verificarUsuario(this.usuario).subscribe(
      data => {

      },
      err => {

      }
    );

    //if (this.usuario.email == "aaa@aaa.com" && this.usuario.senha == "aaa")
    //{
    //  sessionStorage.setItem("usuario-autenticado", "1");
    //  this.router.navigate([this.returnUrl]);
    //}
    }
}
