import  React, {Component} from "react";

export class Produits extends Component{

  constructor(props){
    super(props);
this.state = {produits:[]}
  }

refreshList(){
  fetch(process.env.React_APP_API+"Produits")
  .then(Response=>Response.json)
  .then(data=>{
    this.setState= ({produits:data});
  })
}

componentDidMount(){
  this.refreshList();
}

componentDidUpdate(){
  this.refreshList();

}
  render(){
const {produits}=this.state;
    return <div className="mt-5 d-flex justify-content-left">
       <ul>
         {produits.map(p=>
         <li text={p.id} > {p.Nom_Produit} </li>
         )}
       </ul> 
    </div>
  }
  
}