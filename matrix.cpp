#include <iostream>
#include <vector>




template<typename T>
class matrix{


    int rows_;
    int cols_;
    std::vector<std::vector<T>> data;


public:
    matrix(size_t rows,size_t cols, T value = T()) : rows_(rows),cols_(cols),data(rows,std::vector<T>(cols,value))
    {

    }


    matrix(matrix&& other) : data(std::move(other.data)),rows_(std::move(other.rows_)),cols_(std::move(other.cols_))
    {
        
    }

    matrix operator=(matrix&& other)
    {
        if(&other != this)
        {
            data = std::move(other.data);
            rows_ = std::move(other.rows_);
            cols_ = std::move(other.cols_);
            return *this;
        }
        return *this;
        
    }

    matrix operator+(const matrix& m) const
    {
        matrix result(rows_,cols_);
        for(int i = 0; i < rows_;i++)
        {
            for(int j = 0; j < cols_;j++) result.data[i][j] = data[i][j] + m.data[i][j];
        }
        return result;
    }

    matrix operator-(const matrix& m) const
    {
        matrix result(rows_,cols_);
        for(int i = 0; i < rows_;i++)
        {
            for(int j = 0; j < cols_;j++) result.data[i][j] = data[i][j] - m.data[i][j];
        }
        return result;
    }

    matrix operator*(const matrix& m) const
    {
        matrix result(rows_,cols_);
        for(int i = 0; i < rows_;i++)
        {
            for(int j = 0; j < cols_;j++) result.data[i][j] = data[i][j] * m.data[i][j];
        }
        return result;
    }

    matrix(const matrix& other) : data(other.data),rows_(other.rows_),cols_(other.cols_)
    {
        
    }

    matrix operator=(const matrix& other)
    {
        if(&other != this)
        {
            data = other.data;
            rows_ = other.rows_;
            cols_ = other.cols_;
            return *this;
        }
        return *this;
        
    }

    const std::vector<T>& operator[](const size_t& x) const
    {
        return data[x];
    }

    std::vector<T>& operator[](const size_t& x)
    {
        return data[x];
    }


    void print() const
    {
        for(int i = 0; i < rows_;i++)
        {
            for(int j = 0;j < cols_;j++)
            {
                std::cout << data[i][j] << " ";

            }
            std::cout << "\n";
        }
    }




};




int main()
{
    matrix<int> x{2,8,4};
    matrix<int> y{2,8,4};

    (x-y).print();
    x[0][0] = 5;
    std::cout << x[0][0] << "\n";
}