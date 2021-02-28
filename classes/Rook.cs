using System;
public class Rook : Piece{
    public Rook(PieceColour p) : base(p)
    {
    if (p == PieceColour.BLACK)
      this.setSymbol("♜");
    else
      this.setSymbol("♖");
    }
    public override bool isLegitMove(int i0, int j0, int i1, int j1, Board board){
  		base.isLegitMove(i0, j0, i1, j1, board);

        if (horizontal > 0 && vertical==0){ //check horizontal movement positive
            for (int x=1; x < abs_horizontal; x++){
                if (board.hasPiece(i0,j0+x)){
                    return false;
                }
            }
            if (((board.hasPiece(i1, j1) && (board.getPiece(i1,j1).getColour() != this.getColour())) || board.hasPiece(i1,j1) == false )){
                return true;
            }
        }
        else if (horizontal < 0 && vertical==0){ //check horizontal movement negative
            for (int x=1; x < abs_horizontal; x++){
                if (board.hasPiece(i0,j0-x)){
                    return false;
                }
            }
            if (((board.hasPiece(i1, j1) && (board.getPiece(i1,j1).getColour() != this.getColour())) || board.hasPiece(i1,j1) == false )){
                return true;
            }
        }
        else if (horizontal==0 && vertical>0){ //check vertical movement positive
            for (int x=1; x < abs_vertical; x++){
                if (board.hasPiece(i0+x,j0)){
                    return false;
                }
            }
            if (((board.hasPiece(i1, j1) && (board.getPiece(i1,j1).getColour() != this.getColour())) || board.hasPiece(i1,j1) == false )){
                return true;
            }
        }
         else if (horizontal==0 && vertical<0){ //check vertical movement negative
            for (int x=1; x < abs_vertical; x++){
                if (board.hasPiece(i0-x,j0)){
                    return false;
                }
            }
            if (((board.hasPiece(i1, j1) && (board.getPiece(i1,j1).getColour() != this.getColour())) || board.hasPiece(i1,j1) == false )){
                return true;
            }
        }
		return false;
    }
}
